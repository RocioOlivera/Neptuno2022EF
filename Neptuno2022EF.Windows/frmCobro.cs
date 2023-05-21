using Neptuno2022EF.Entidades.Dtos.CtaCte;
using Neptuno2022EF.Entidades.Dtos.DetalleCtaCte;
using Neptuno2022EF.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neptuno2022EF.Windows
{
    public partial class frmCobro : Form
    {
        public frmCobro()
        {
            InitializeComponent();
        }
        private decimal montoAPagar;
        private decimal importeRecibido;
        private CtaCteDetalleDto ctaCteList;
        private void btnOk_Load(object sender, EventArgs e)
        {
            lblImporteACobrar.Text = importeRecibido.ToString("N2");
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (ctaCteList != null)
            {

                //lblImporteACobrar.Text = ctaCteList.Saldo.ToString();


            }
        }

        public void SetCobro(CtaCteDetalleDto detalle)
        {
            ctaCteList = detalle;
        }

    }
}
