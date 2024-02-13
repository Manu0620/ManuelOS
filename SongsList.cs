using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManuelOS
{
    public partial class SongsList : UserControl
    {
        public event EventHandler onSongSelected;
        public SongsList()
        {
            InitializeComponent();
        }

        private void songList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            onSongSelected?.Invoke(this, EventArgs.Empty);
        }
    }
}
