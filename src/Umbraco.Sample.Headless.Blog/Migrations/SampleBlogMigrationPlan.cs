using System;
using Umbraco.Cms.Core.Packaging;

namespace Umbraco.Sample.Headless.Blog.Migrations;

public class SampleBlogMigrationPlan : PackageMigrationPlan
{
    public SampleBlogMigrationPlan() : base("Blog Sample Data")
    {
    }

    protected override void DefinePlan()
        => To<InstallSampleDataPackageMigration>(new Guid("D18BE3B5-B247-47DE-8FFE-8D9D6522F415"));
}