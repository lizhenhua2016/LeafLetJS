// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BundleConfig.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the BundleConfig type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LeafLetJS
{
    using System.Web.Optimization;

    /// <summary>
    /// The bundle config.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862

        /// <summary>
        /// The register bundles.
        /// </summary>
        /// <param name="bundles">
        /// The bundles.
        /// </param>
        public static void RegisterBundles(BundleCollection bundles)
        {    
            bundles.Add(new ScriptBundle("~/bundles/leafletjs").Include("~/Scripts/leaflet-{version}.js"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*")); 
            bundles.Add(new StyleBundle("~/Content/leafletjs").Include("~/Content/leaflet.css"));
        }
    }
}