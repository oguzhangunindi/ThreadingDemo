using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadingDemo
{
    public partial class Form1 : Form
    {
        int timerTick = 0;
        public enum labelFnNames
        {
            labelYumurtaKir,
            labelYumurtaCirp,
            labelTuzEkle,
            labelOcagiAc,
            labelTavayiIsit,
            labelYagiDok,
            labelYumurtaEkle,
            labelPisir,
            labelServisEt
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var timer = new System.Timers.Timer
            {
                Interval = 1000
            };
        }
        private async void btnAsyncProcess_Click(object sender, EventArgs e)
        {
            timerTick = 0;
            timer.Start();
            listProcces.Items.Clear();
            labelAdjustClear();
            var yumurtaTaskGroup = await YumurtalariKir()
                .ContinueWith(async _ =>
                {
                    await YumurtalariCirp();
                    await TuzEkle();
                }, TaskScheduler.FromCurrentSynchronizationContext());

            var ocakTaskGroup = await OcagiAc().ContinueWith(async _ =>
            {
                await YagiDok();
                await TavayiIsit();
            }, TaskScheduler.FromCurrentSynchronizationContext());
            await Task.WhenAll(yumurtaTaskGroup, ocakTaskGroup);
            await YumurtaEkle();
            await Pisir();
            await ServisEt();
            timer.Stop();
            listAdd(listProcces, "Yemek " + timerTick++.ToString() + " Saniyede Hazırlandı!");
        }

        public void labelAdjustClear()
        {
            string[] fnNames = Enum.GetNames(typeof(labelFnNames));
            foreach (string fn in fnNames)
            {
                this.Controls[fn].BackColor = Color.White;
            }
        }

        public void labelAdjust(Label label)
        {
            label.BackColor = Color.Green;
        }
        public void listAdd(ListBox list, string message)
        {
            list.Items.Add(DateTime.Now + " - " + message);
        }
        public async Task YumurtalariKir()
        {
            await Task.Delay(200);
            listAdd(listProcces, "Yumurtalar Kırıldı");
            labelAdjust(labelYumurtaKir);
        }
        public async Task YumurtalariCirp()
        {
            await Task.Delay(400);
            listAdd(listProcces, "Yumurtalar Çırpıldı");
            labelAdjust(labelYumurtaCirp);
        }
        public async Task TuzEkle()
        {
            await Task.Delay(200);
            listAdd(listProcces, "Tuz Eklendi");
            labelAdjust(labelTuzEkle);
        }
        public async Task OcagiAc()
        {
            await Task.Delay(200);
            listAdd(listProcces, "Ocak Açıldı");
            labelAdjust(labelOcagiAc);
        }
        public async Task TavayiIsit()
        {
            await Task.Delay(600);
            listAdd(listProcces, "Tava Isıtıldı");
            labelAdjust(labelTavayiIsit);
        }
        public async Task YagiDok()
        {
            await Task.Delay(200);
            listAdd(listProcces, "Yağ Döküldü");
            labelAdjust(labelYagiDok);
        }
        public async Task YumurtaEkle()
        {
            await Task.Delay(200);
            listAdd(listProcces, "Yumurta Eklendi");
            labelAdjust(labelYumurtaEkle);
        }
        public async Task Pisir()
        {
            await Task.Delay(600);
            listAdd(listProcces, "Yemek Pişirildi");
            labelAdjust(labelPisir);
        }
        public async Task ServisEt()
        {
            await Task.Delay(200);
            listAdd(listProcces, "Yemek Servis Edildi");
            labelAdjust(labelServisEt);
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            timerTick++;
            labelTimer.Text = timerTick.ToString();
        }


    }
}
