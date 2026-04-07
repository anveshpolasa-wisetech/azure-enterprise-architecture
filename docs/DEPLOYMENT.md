# Deployment Guide

This document outlines the complete deployment guide for the Azure Enterprise Architecture.

## Prerequisites
- An Azure account with the necessary permissions.
- Installation of Azure CLI.
- Bicep CLI installed.
- Access to a suitable code editor or IDE.

## Environment Setup
1. Clone the repository:  
   `git clone https://github.com/anveshpolasa-wisetech/azure-enterprise-architecture.git`
2. Navigate to the cloned directory:  
   `cd azure-enterprise-architecture`
3. Ensure you have the necessary tools installed (Azure CLI and Bicep).

## Azure Login
1. Open your terminal.
2. Run the command:  
   `az login`
3. Follow the prompts to authenticate.

## Infrastructure Deployment with Bicep
1. Navigate to the Bicep templates directory:  
   `cd bicep-templates`
2. Deploy the infrastructure using the Bicep file:  
   `az deployment sub create --location <location> --template-file main.bicep`
   Replace `<location>` with your desired Azure region.

## Database Setup
1. Choose the database service (e.g., Azure SQL Database).
2. Create a new database instance using the Azure Portal or CLI.
3. Configure the database connection strings in your app’s configuration files.

## Key Vault Configuration
1. Create a Key Vault in the Azure Portal.
2. Add necessary secrets and access policies.
3. Update your application to retrieve secrets from the Key Vault.

## Application Deployment
1. Build your application:  
   `dotnet build`
2. Publish the application:  
   `dotnet publish -c Release`
3. Deploy the application using Azure CLI or the Azure Portal.

## Function App Deployment
1. Create a Function App in Azure.
2. Deploy your function app code:  
   `func azure functionapp publish <FunctionAppName>`
   Replace `<FunctionAppName>` with the name of your Azure Function.

## Verification Steps
- Access your application through the URL provided after deployment.
- Check the Azure Portal for the active resources and their statuses.

## Troubleshooting
- If you encounter issues, check the logs in Azure Portal under each service section.
- Verify network configurations and security settings.
- Consult the Azure documentation for specific service errors.

## Rollback Procedures
- To roll back any changes, revert to the previous version of code from your source control.
- Redeploy using the previous database backup if needed.
- Restore any previous infrastructure if necessary using Bicep or manual configuration.