using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Color = Entities.Concrete.Color;
using FormsUI;


namespace FormsUI
{
    public partial class AddColor : Form
    {
        public AddColor()
        {
            InitializeComponent();
        }

        private void btnSaveColorName_Click(object sender, EventArgs e)
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var color = new Color { Name = tbxColorName.Text };
            colorManager.Add(color);
        }
    }
}
