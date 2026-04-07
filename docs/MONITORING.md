# Monitoring and Observability Guide

## Application Insights Setup
1. Go to the Azure portal.
2. Navigate to "Application Insights" and click on "Create".
3. Fill in the necessary details:
   - Subscription
   - Resource Group
   - Name
   - Region
4. Click on "Review + Create" and then "Create".
5. Once created, instrument your application using the SDK provided by Application Insights.

## Log Analytics Configuration
1. Access your Log Analytics workspace in the Azure portal.
2. Link it with your Application Insights resource.
3. Follow the prompts to enable data collection.

## KQL Queries
- **Requests**: `requests | summarize count() by bin(timestamp, 1h)`
- **Exceptions**: `exceptions | summarize count() by bin(timestamp, 1h)`
- **Dependencies**: `dependencies | summarize count() by bin(timestamp, 1h)`
- **Performance Analysis**: `performanceCounters | where name =~ 'CPU Percentage'`

## Alert Rules Configuration
1. In the Azure portal, navigate to your Application Insights resource.
2. Select "Alerts" and click on "New Alert Rule".
3. Define the condition, action group, and other necessary settings to set up the alerts.

## Action Groups
- Create action groups in the Azure portal to define who gets alerted and how.
- Configure notifications for email, SMS, or other channels.

## Troubleshooting Common Issues
- Check if telemetry is being sent from your application.
- Ensure that Application Insights SDK is properly configured.
- Review the logs in Log Analytics for any discrepancies.

## Performance Baselines
- Utilize the metrics in Application Insights to identify normal performance levels.
- Set up alerts based on deviations from these baselines.

## Cost Optimization
- Review the data retention settings in Log Analytics to manage costs.
- Set up sampling in Application Insights to reduce data volume.

## Monitoring Checklist
- Ensure Application Insights is set up correctly.
- Configure Log Analytics to capture the necessary data.
- Create key KQL queries for performance insights.
- Set up alert rules and action groups for incident management.
- Regularly review performance baselines and costs.