using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenadores
{
    public partial class Ordenadores : Form
    {
        List<int> generatedNums = new List<int>();
        List<int> generatedSorted = new List<int>();

        public Ordenadores()
        {
            InitializeComponent();
        }

        private void txtQntd_TextChanged_1(object sender, EventArgs e)
        {
            // Max de caracteres 4 no txtQntd
            txtQntd.MaxLength = 4;
        }

        private void LimparTudo()
        {
            // Limpa TUDO
            txtQntd.Clear();
            txtNum.Clear();
            generatedNums.Clear();
            generatedSorted.Clear();
            labelTempo.Text = "";
            labelTime.Text = "";
           
            var checkedRadio = this.Controls.OfType<RadioButton>()
                                     .FirstOrDefault(r => r.Checked);
            if (checkedRadio != null)
            {
                checkedRadio.Checked = false;
            }
            
        }

        private void Gerar_Click(object sender, EventArgs e)
        {
            //Limpa tudo
            txtNum.Clear();
            generatedSorted.Clear();
            generatedNums.Clear();
            labelTempo.Text = "";
            labelTime.Text = "";
            if (String.IsNullOrEmpty(txtQntd.Text) || txtQntd.Text == "0")
            {
                // MSG se caixa de txt tiver vazio/zerada
                MessageBox.Show("Insira uma quantidade de números válida!");
            }
            else
            {
                // Gera qntd de num aleatorios digitada no txt
                int valor = Convert.ToInt32(txtQntd.Text);
                Random randNum = new Random();

                for (int i = 0; i < valor; i++)
                {
                    int num = randNum.Next(100);
                    if (i != valor - 1)
                    {
                        txtNum.AppendText(num.ToString() + ", ");
                        generatedNums.Add(num);
                    }
                    else
                    {
                        txtNum.AppendText(num.ToString() + ".");
                        generatedNums.Add(num);
                        generatedSorted.Add(num);
                    }

                }
                
            }
            
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            // Botao exec metod LimparTudo
            LimparTudo();
        }

        private void Ordenar_Click(object sender, EventArgs e)
        {
            // Ordena no algoritmo selecionado no radioButton
            var checkedRadio = this.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            List<Int32> generatedSorted = new List<Int32>(generatedNums);
            if (generatedNums.Count == 0)
            {
                MessageBox.Show("Favor gerar os números a serem ordenados!");
            }
            else if (checkedRadio == null)
            {
                MessageBox.Show("Escolha uma opção de ordenação!");
            }
            else if (checkedRadio.Text == "Quick Sort")
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                int inicio = 0;
                int fim = generatedSorted.Count - 1;
                quickSort(generatedSorted, inicio, fim);
                watch.Stop();
                var elapsedMs = watch.Elapsed.TotalMilliseconds;
                labelTempo.Text = "Tempo";
                labelTime.Text = elapsedMs.ToString() + " ms";
            }
            else if (checkedRadio.Text == "Bubble Sort")
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                int tamanho = generatedSorted.Count;
                int comparacoes = 0;
                int trocas = 0;

                for (int i = tamanho - 1; i >= 1; i--)
                {
                    for (int j = 0; j < i; j++)
                    {
                        comparacoes++;
                        if (generatedSorted[j] > generatedSorted[j + 1])
                        {
                            int aux = generatedSorted[j];
                            generatedSorted[j] = generatedSorted[j + 1];
                            generatedSorted[j + 1] = aux;
                            trocas++;
                        }
                    }
                }
                watch.Stop();
                var elapsedMs = watch.Elapsed.TotalMilliseconds;
                labelTempo.Text = "Tempo";
                labelTime.Text = elapsedMs.ToString() + " ms";
            }
            else if (checkedRadio.Text == "Heap Sort")
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                buildMaxHeap(generatedSorted);
                int n = generatedSorted.Count;

                for (int i = generatedSorted.Count - 1; i > 0; i--)
                {
                    swap(generatedSorted, i, 0);
                    maxHeapify(generatedSorted, 0, --n);
                }
                watch.Stop();
                var elapsedMs = watch.Elapsed.TotalMilliseconds;
                labelTempo.Text = "Tempo";
                labelTime.Text = elapsedMs.ToString() + " ms";
            }
            else if (checkedRadio.Text == "Selection Sort")
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                int min, aux;

                for (int i = 0; i < generatedSorted.Count - 1; i++)
                {
                    min = i;

                    for (int j = i + 1; j < generatedSorted.Count; j++)
                        if (generatedSorted[j] < generatedSorted[min])
                            min = j;

                    if (min != i)
                    {
                        aux = generatedSorted[min];
                        generatedSorted[min] = generatedSorted[i];
                        generatedSorted[i] = aux;
                    }
                }
                watch.Stop();
                var elapsedMs = watch.Elapsed.TotalMilliseconds;
                labelTempo.Text = "Tempo";
                labelTime.Text = elapsedMs.ToString() + " ms";
            }
            else if (checkedRadio.Text == "Insertion Sort")
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                int i, j, atual;
                for (i = 1; i < generatedSorted.Count; i++)
                {
                    atual = generatedSorted[i];
                    j = i;
                    while ((j > 0) && (generatedSorted[j - 1] > atual))
                    {
                        generatedSorted[j] = generatedSorted[j - 1];
                        j = j - 1;
                    }
                    generatedSorted[j] = atual;
                }
                watch.Stop();
                var elapsedMs = watch.Elapsed.TotalMilliseconds;
                labelTempo.Text = "Tempo";
                labelTime.Text = elapsedMs.ToString() + " ms";
            }
            txtNum.Clear();
            for (int i = 0; i < generatedSorted.Count; i++)
            {
                if (i != generatedSorted.Count - 1)
                {
                    txtNum.AppendText(generatedSorted[i] + ", ");
                }
                else
                {
                    txtNum.AppendText(generatedSorted[i] + ".");
                }

            }
        }

        private static void quickSort(List<int> generatedSorted, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int p = generatedSorted[inicio];
                int i = inicio + 1;
                int f = fim;

                while (i <= f)
                {
                    if (generatedSorted[i] <= p)
                    {
                        i++;
                    }
                    else if (p < generatedSorted[f])
                    {
                        f--;
                    }
                    else
                    {
                        int troca = generatedSorted[i];
                        generatedSorted[i] = generatedSorted[f];
                        generatedSorted[f] = troca;
                        i++;
                        f--;
                    }
                }

                generatedSorted[inicio] = generatedSorted[f];
                generatedSorted[f] = p;

                quickSort(generatedSorted, inicio, f - 1);
                quickSort(generatedSorted, f + 1, fim);
            }
        }

        private static void buildMaxHeap(List<int> generatedSorted)
        {
            for (int i = generatedSorted.Count / 2 - 1; i >= 0; i--)
            {
                maxHeapify(generatedSorted, i, generatedSorted.Count);
            }
        }

        private static void maxHeapify(List<int> generatedSorted, int pos, int n)
        {
            int max = 2 * pos + 1, right = max + 1;
            if (max < n)
            {
                if (right < n && generatedSorted[max] < generatedSorted[right])
		        {
                    max = right;
                }
                if (generatedSorted[max] > generatedSorted[pos])
                {
                    swap(generatedSorted, max, pos);
                    maxHeapify(generatedSorted, max, n);
                }
            }
        }

        private static void swap(List<int> generatedSorted, int j, int aposJ)
        {
            int aux = generatedSorted[j];
            generatedSorted[j] = generatedSorted[aposJ];
            generatedSorted[aposJ] = aux;
        }


    }
}
