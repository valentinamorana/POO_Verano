using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TP_UN1_Morana_POO.EJ2;

namespace TP_UN1_Morana_POO.EJ2
{
    public partial class Banco : Form
    {
        private Cuenta cuenta;

        public Banco()
        {
            InitializeComponent();
        }

        private void Banco_Load(object sender, EventArgs e)
        {
            lblSaldo.Text = "Saldo: -";
        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            string titular = txtTitular.Text.Trim(); //Trim() saca espacios al inicio/final
            decimal saldoInicial;

            if (string.IsNullOrEmpty(titular))
            {
                MessageBox.Show("Ingresá un titular.");
                return;
            }

            if (!decimal.TryParse(txtSaldoInicial.Text, out saldoInicial)) //TryParse intenta convertir texto a decimal.
            {
                MessageBox.Show("Saldo inicial inválido");
                return;
            }

            cuenta = new Cuenta(titular, saldoInicial); // Crea el objeto, define el estado inicial: titular + saldo inicial.
            ActualizarVista();

            MessageBox.Show("Cuenta creada correctamente.");
        }

        private void ActualizarVista()
        {
            lblSaldo.Text = "Saldo: " + cuenta.Saldo;
        }

        private bool ValidarCuentaCreada()
        {
            if (cuenta == null)
            {
                MessageBox.Show("Primero tenés que crear la cuenta.");
                return false;
            }
            return true;
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (!ValidarCuentaCreada()) return;

            decimal monto;
            if (!decimal.TryParse(txtMonto.Text, out monto))
            {
                MessageBox.Show("Monto inválido");
                return;
            }

            cuenta.Depositar(monto);
            ActualizarVista();
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            if (!ValidarCuentaCreada()) return;

            decimal monto;
            if (!decimal.TryParse(txtMonto.Text, out monto))
            {
                MessageBox.Show("Monto inválido");
                return;
            }

            cuenta.Extraer(monto);
            ActualizarVista();
        }

        private void btnTransferir_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCuentaCreada()) return;

            decimal monto;
            if (!decimal.TryParse(txtMonto.Text, out monto))
            {
                MessageBox.Show("Monto inválido");
                return;
            }

            string titularDestino = txtTitularDestino.Text.Trim();

            if (string.IsNullOrEmpty(titularDestino))
            {
                MessageBox.Show("Ingresá el titular destino.");
                return;
            }

            if (titularDestino == cuenta.Titular)
            {
                MessageBox.Show("No podés transferirte a la misma cuenta.");
                return;
            }

            // Creamos una cuenta destino simple con saldo 0
            Cuenta cuentaDestino = new Cuenta(titularDestino, 0);

            cuenta.Transferir(cuentaDestino, monto);

            ActualizarVista();

            MessageBox.Show("Transferencia realizada.\nSaldo destino: " + cuentaDestino.Saldo);
        }
    }
}