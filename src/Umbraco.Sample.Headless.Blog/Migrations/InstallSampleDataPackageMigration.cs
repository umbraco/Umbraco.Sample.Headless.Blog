﻿using Microsoft.Extensions.Options;
using Umbraco.Cms.Core.Configuration.Models;
using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Strings;
using Umbraco.Cms.Infrastructure.Migrations;
using Umbraco.Cms.Infrastructure.Packaging;

namespace Umbraco.Sample.Headless.Blog.Migrations;

public class InstallSampleDataPackageMigration : PackageMigrationBase
{
    public InstallSampleDataPackageMigration(IPackagingService packagingService, IMediaService mediaService, MediaFileManager mediaFileManager, MediaUrlGeneratorCollection mediaUrlGenerators, IShortStringHelper shortStringHelper, IContentTypeBaseServiceProvider contentTypeBaseServiceProvider, IMigrationContext context, IOptions<PackageMigrationSettings> packageMigrationsSettings)
        : base(packagingService, mediaService, mediaFileManager, mediaUrlGenerators, shortStringHelper, contentTypeBaseServiceProvider, context, packageMigrationsSettings)
    {
    }

    protected override void Migrate()
        => ImportPackage.FromEmbeddedResource<InstallSampleDataPackageMigration>().Do();
}