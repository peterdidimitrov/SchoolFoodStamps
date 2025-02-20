variable "sql_admin_password" {
  description = "The password for the SQL server admin."
  type        = string
  sensitive   = true
}

variable "dockerhub_username" {
  description = "Docker Hub username"
  type        = string
  sensitive   = true
}

variable "dockerhub_password" {
  description = "Docker Hub password"
  type        = string
  sensitive   = true
}

variable "azure_subscription_id" {
  description = "Subscription ID"
  type        = string
  sensitive   = true
}
