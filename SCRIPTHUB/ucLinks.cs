using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCRIPTHUB
{
    public partial class ucLinks : UserControl
    {
        public ucLinks()
        {
            InitializeComponent();
        }
        private void OpenUrl(string url)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(startInfo);
        }

        private void btnTS_Click(object sender, EventArgs e)
        {

            OpenUrl("http://gdlprodsrv.gdl.mex.ibm.com/prodsrv/ivt/status/status_test.php");
        }

        private void btnLQ_Click(object sender, EventArgs e)
        {
            OpenUrl("https://gdlprodsrv.gdl.mex.ibm.com/prodsrv/ivt/logs/zip.php");
        }

        private void btnWUS_Click(object sender, EventArgs e)
        {
            OpenUrl("https://gdlprodsrv.gdl.mex.ibm.com/prodsrv/molesz/MachineWUStatus/");
        }

        private void btnLuna_Click(object sender, EventArgs e)
        {
            OpenUrl("https://luna.us1a.cirrus.ibm.com/projects/engineering/incident-tracker-stg");
        }

        private void btnRechazos_Click(object sender, EventArgs e)
        {
            OpenUrl("https://c01prod.ahe.pok.ibm.com:45002/ncm4sap/jsp/NCMSecureLoginG.jsp");
        }

        private void btnJL_Click(object sender, EventArgs e)
        {
            OpenUrl("https://gdlprodsrv.gdl.mex.ibm.com/prodsrv/molesz/JadeLogViewer/");
        }

        private void btnTP_Click(object sender, EventArgs e)
        {
            OpenUrl("https://gdlprodsrv.gdl.mex.ibm.com/prodsrv/molesz/TestProblems/");
        }

        private void btnPH_Click(object sender, EventArgs e)
        {
            OpenUrl("https://gdlprodsrv.gdl.mex.ibm.com/prodsrv/molesz/PartsHistory/");
        }

        private void btnKC_Click(object sender, EventArgs e)
        {
            OpenUrl("http://rschost.raleigh.ibm.com:9090/support/knowledgecenter/");
        }

        private void btnVT_Click(object sender, EventArgs e)
        {
            OpenUrl("https://w3.ibm.com/epm/bcacognos/bi/?perspective=authoring&pathRef=.public_folders%2FISC%2BGDL%2BREPORTS%2FStorage%2BManufacturing%2BReports%2FMANUFACTURING%2BHELP%2FValidacion%2Bde%2Bpruebas&id=i5B8D2EB8162E440C9AE5D72866F747E1&objRef=i5B8D2EB8162E440C9AE5D72866F747E1&action=run&format=HTML&cmPropStr=%7B%22id%22%3A%22i5B8D2EB8162E440C9AE5D72866F747E1%22%2C%22type%22%3A%22report%22%2C%22defaultName%22%3A%22Validacion%20de%20pruebas%22%2C%22permissions%22%3A%5B%22execute%22%2C%22read%22%2C%22traverse%22%5D%7D");
        }

        private void btnT290_Click(object sender, EventArgs e)
        {
            OpenUrl("https://ibm.ent.box.com/integrations/officeonline/openOfficeOnline?fileId=1292168471861&sharedAccessCode=");
        }

        private void btnFRUR8_Click(object sender, EventArgs e)
        {
            OpenUrl("https://ibm.ent.box.com/integrations/officeonline/openOfficeOnline?fileId=1471825897995&sharedAccessCode=");
        }

        private void btnCheckL_Click(object sender, EventArgs e)
        {
            OpenUrl("https://ibm.ent.box.com/folder/252823802333");
        }

        private void btnBRechazos_Click(object sender, EventArgs e)
        {
            OpenUrl("https://ibm.ent.box.com/integrations/officeonline/openOfficeOnline?fileId=878036556979&sharedAccessCode=");
        }

        private void btnYL_Click(object sender, EventArgs e)
        {
            OpenUrl("https://yourlearning.ibm.com/");
        }

        private void btnITool_Click(object sender, EventArgs e)
        {
            OpenUrl("https://g53xr00009240.az13.dal.cpc.ibm.com:62025/home");
        }

        private void btnCP_Click(object sender, EventArgs e)
        {
            OpenUrl("https://cloud.workhuman.com/conversations/#/ibmcorp/26824568/dashboard");
        }

        private void btnBPoints_Click(object sender, EventArgs e)
        {
            OpenUrl("https://ibmrr.performnet.com/ibmrr/homePage.do");
        }

        private void btnCTool_Click(object sender, EventArgs e)
        {
            OpenUrl("https://cert-tool-prod.wdc1a.cirrus.ibm.com/#/login");
        }

        private void btnCTG_Click(object sender, EventArgs e)
        {
            OpenUrl("https://w3.ibm.com/w3publisher/transporte-ctg-ibm-2021");
        }

        private void btnPCA_Click(object sender, EventArgs e)
        {
            OpenUrl("https://w3.ibm.com/w3publisher/people-choice-awards");
        }

        private void btnWDay_Click(object sender, EventArgs e)
        {
            OpenUrl("https://wd5.myworkday.com/ibm/d/home.htmld");
        }

        private void btnComedor_Click(object sender, EventArgs e)
        {
            OpenUrl("https://w3.ibm.com/w3publisher/gre-mexico/guadalajara/comedor-gdl");
        }

        private void btnHumaneland_Click(object sender, EventArgs e)
        {
            OpenUrl("https://humaneland.net/login/login.xhtml");
        }
    }
}
