﻿using System.ComponentModel.DataAnnotations;
using MigrationTools.Endpoints.Infrastructure;

namespace MigrationTools.Endpoints
{
    public class AzureDevOpsEndpointOptions : EndpointOptions
    {
        [Required]
        public AuthenticationMode AuthenticationMode { get; set; }

        [Required]
        public string AccessToken { get; set; }

        [Required]
        public string Organisation { get; set; }

        [Required]
        public string Project { get; set; }

        [Required]
        public string ReflectedWorkItemIdField { get; set; }


        //public override void SetDefaults()
        //{
        //    base.SetDefaults();
        //    AccessToken = MigrationTools.Tests.TestingConstants.AccessToken;
        //    Organisation = "https://dev.azure.com/nkdagility-preview/";
        //    Project = "NeedToSetThis";
        //    ReflectedWorkItemIdField = "Custom.ReflectedWorkItemId";
        //}
    }
}