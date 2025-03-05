provider "azurerm" {
  features {}
  use_msi = false
  client_id       = var.client_id
  client_secret   = var.client_secret
  subscription_id = var.subscription_id
  tenant_id       = var.tenant_id
}

resource "azurerm_resource_group" "rg" {
  name     = "schoolfoodstamps-rg"
  location = "North Europe"
}

resource "azurerm_mssql_server" "sqlserver" {
  name                         = "schoolfoodstamps-sqlserver"
  resource_group_name          = azurerm_resource_group.rg.name
  location                     = azurerm_resource_group.rg.location
  version                      = "12.0"
  administrator_login          = "sqladmin"
  administrator_login_password = var.sql_admin_password
}

resource "azurerm_mssql_firewall_rule" "allow_azure_services" {
  name             = "AllowAzureServices"
  server_id        = azurerm_mssql_server.sqlserver.id
  start_ip_address = "0.0.0.0"
  end_ip_address   = "0.0.0.0"
}

resource "azurerm_mssql_database" "sqldb" {
  name           = "schoolfoodstampsdb"
  server_id      = azurerm_mssql_server.sqlserver.id
  sku_name       = "Basic"
}

resource "azurerm_container_group" "app" {
  name                = "schoolfoodstamps-app"
  location            = azurerm_resource_group.rg.location
  resource_group_name = azurerm_resource_group.rg.name
  os_type             = "Linux"

  lifecycle {
    ignore_changes = [tags, container, image_registry_credential]
  }

  container {
    name   = "dotnet-app"
    image  = "ogmos/schoolfoodstamps-app:latest"
    cpu    = "0.5"
    memory = "1.5"

    ports {
      port     = 80
      protocol = "TCP"
    }

    ports {
      port     = 443
      protocol = "TCP"
    }

    environment_variables = {

      "ConnectionStrings__DefaultConnection" = "Server=tcp:${azurerm_mssql_server.sqlserver.fully_qualified_domain_name},1433;Initial Catalog=${azurerm_mssql_database.sqldb.name};Persist Security Info=False;User ID=sqladmin;Password=${var.sql_admin_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
    }
  }

  image_registry_credential {
    server   = "index.docker.io"
    username = var.dockerhub_username
    password = var.dockerhub_password
  }

  tags = {
    environment = "production"
  }

  dns_name_label = "schoolfoodstamps-app"
}