using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Parser_v0._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnParse_Click(object sender, EventArgs e)
        {
            string url = txtLink.Text;

            try
            {

                using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(url);
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                long lastHeight = (long)js.ExecuteScript("return document.body.scrollHeight");
                while (true)
                {
                    js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
                    Thread.Sleep(2000);
                    long newHeight = (long)js.ExecuteScript("return document.body.scrollHeight");
                    if (newHeight == lastHeight)
                    {
                        break;
                    }
                    lastHeight = newHeight;
                }
                string html = driver.PageSource;
                File.WriteAllText("page.txt", html);
            }
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string html = File.ReadAllText("page.txt");
                        string[] lines1 = html.Split(new string[] { "</a>" }, StringSplitOptions.None);

                        var farmWorldLines = new List<string>();
                        double result = 0;
                        bool positive = true;
                        foreach (string line in lines1)
                        {
                            if (line.Contains("farm-world"))
                            {
                                positive = true;
                                int startIndex = line.IndexOf("+");
                                if (startIndex == -1)
                                {
                                    startIndex = line.IndexOf("−");
                                    positive = false;
                                }
                                if (startIndex != -1)
                                {
                                    int endIndex = line.IndexOf("TON", startIndex);
                                    if (endIndex != -1)
                                    {
                                        string tonPart = line.Substring(startIndex, endIndex - startIndex);
                                        string cleanedTonPart = Regex.Replace(tonPart, @"[^\d\.\+\-]", "");
                                        if (double.TryParse(cleanedTonPart, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                                        {
                                            if (positive)
                                            {
                                                result += number;
                                            }
                                            else
                                            {
                                                result += -number;
                                            }
                                            farmWorldLines.Add(tonPart + " TON\n");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ошибка преобразования строки в число: " + tonPart);
                                        }
                                    }
                                }
                            }
                        }
                        lbInfo.Items.AddRange(farmWorldLines.ToArray());
                        if (result > 0)
                        {
                            txtResult.Text = "Result: +" + result.ToString() + " TON";
                        }
                        else
                        {
                            txtResult.Text = "Result: " + result.ToString() + " TON";
                        }
                        btnParse.Enabled = false;
                        btnClear.Enabled = true;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }

        private void lbInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLink.Clear();
            lbInfo.Items.Clear();
            txtResult.Clear();
            btnParse.Enabled = true;
            btnClear.Enabled = false;
        }
    }
}
