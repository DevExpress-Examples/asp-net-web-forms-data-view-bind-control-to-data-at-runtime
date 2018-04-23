#region #usings
using DevExpress.Web;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Web.UI;
#endregion #usings

public partial class _Default : System.Web.UI.Page {
    #region #binding
    protected void DataView_Load(object sender, System.EventArgs e) {
        DataView.DataSource = GetDataSource();
        #region #templateAssigning
        DataView.ItemTemplate = new MyDataViewTemplate();
        #endregion #templateAssigning
        DataView.DataBind();
    }
    public IEnumerable GetDataSource() {
        IEnumerable dataSource = Enumerable.Range(1, 10).Select(i => new {
            ID = i,
            Name = "Name" + i,
            Description = "Sample description for the item."
        });
        return dataSource;
    }
    #endregion #binding
}