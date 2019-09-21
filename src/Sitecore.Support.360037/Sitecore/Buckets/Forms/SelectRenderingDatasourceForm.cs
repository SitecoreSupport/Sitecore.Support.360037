namespace Sitecore.Support.Buckets.Forms
{
    using System;

    public class SelectRenderingDatasourceForm : Sitecore.Buckets.Forms.SelectRenderingDatasourceForm
    {
        private string CurrentDatasourcePath
        {
            get
            {
                return ServerProperties["current_datasource"] as string;
            }
            set
            {
                ServerProperties["current_datasource"] = value;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            if (!string.IsNullOrEmpty(SelectDatasourceOptions.CurrentDatasource))
            {
                CurrentDatasourcePath = SelectDatasourceOptions.CurrentDatasource;
            }

            base.OnLoad(e);
        }
    }
}
