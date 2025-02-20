output "resource_group_name" {
  value = azurerm_resource_group.rg.name
}

output "sql_server_name" {
  value = azurerm_mssql_server.sqlserver.name
}

output "sql_database_name" {
  value = azurerm_mssql_database.sqldb.name
}

output "container_group_name" {
  value = azurerm_container_group.app.name
}

output "docker_image_url" {
  value = "index.docker.io/ogmos/schoolfoodstamps-app:latest"
}

output "container_public_ip" {
  value = azurerm_container_group.app.ip_address
}

output "container_fqdn" {
  value = azurerm_container_group.app.fqdn
}

output "database_connection_string" {
  value = "Server=tcp:${azurerm_mssql_server.sqlserver.fully_qualified_domain_name},1433;Initial Catalog=${azurerm_mssql_database.sqldb.name};Persist Security Info=False;User ID=sqladmin;Password=${var.sql_admin_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
  sensitive = true
}