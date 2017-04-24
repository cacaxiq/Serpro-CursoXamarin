using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace SerproShared.iOS
{
    class PessoaDataSource : UITableViewSource
    {
        private List<string> lista;

        public PessoaDataSource(List<string> lista)
        {
            this.lista = lista;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return lista.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("listaPessoasCell");
            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, "listaPessoasCell");
            }

            int row = indexPath.Row;
            cell.TextLabel.Text = this.lista[row];
            return cell;
        }
    }
}
