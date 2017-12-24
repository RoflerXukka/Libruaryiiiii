using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public class SearchData
    {
        public SearchData() { }
        public SearchData(int first, int second, int columnNuber, string str, bool UseWordWhole, bool RegistrON, bool UseMultiThreading)
        {
            first_index = first;
            second_index = second;
            numberOfColumn = columnNuber;
            this.str = str;
            this.UseWordWhole = UseWordWhole;
            this.RegistrON = RegistrON;
            this.UseMultiThreading = UseMultiThreading;
        }
        public int first_index { get; set; }
        public int second_index { get; set; }
        public int numberOfColumn { get; set; }
        public string str { get; set; }
        public bool UseWordWhole { get; set; }
        public bool RegistrON { get; set; }
        public bool UseMultiThreading { get; set; }
    }
    public class Helper
    {
        const int Multiplier = 2;
        int resultsOfSearch = 0;
        Searcher search;
        Form descriptor;
        public Helper(Form descriptor)
        {
            this.descriptor = descriptor;
            search = new Searcher();
            search.taskEnded += Search_taskEnded;
        }
        private void Search_taskEnded(int number) => resultsOfSearch += number;
        public void UnHideAllRows(DataGridView dataGrid)
        {
            for (int i = 0; i < dataGrid.RowCount; i++) dataGrid.Rows[i].Visible = true;
        }
        public Task UnHideAllRowsAsync(DataGridView dataGrid)
        {
            return Task.Run(() =>
            {
                for (int i = 0; i < dataGrid.RowCount; i++) descriptor.Invoke((Action)delegate { dataGrid.Rows[i].Visible = true; });
            });
        }
        public Task UnHideAllRowsAsyncUnsafe(DataGridView dataGrid)
        {
            return Task.Run(() =>
            {
                for (int i = 0; i < dataGrid.RowCount; i++) dataGrid.Rows[i].Visible = true;
            });
        }
        public Task<int> StartSearchAnsyc(SearchData data, DataGridView dataGrid)
        {
            return Task.Run( async () =>
            {
                if (data.UseMultiThreading)
                {
                    if (dataGrid.RowCount < Environment.ProcessorCount * Multiplier)
                    {
                        data.UseMultiThreading = false;
                        await search.ThreadSearch(data, dataGrid, descriptor);
                        goto cont;
                    }
                    int first_index = 0, second_index, step;
                    SearchData[] datas = new SearchData[Environment.ProcessorCount * Multiplier];
                    step = dataGrid.RowCount / datas.Length;
                    second_index = step;
                    for (int i = 0; i < Environment.ProcessorCount * Multiplier; i++)
                    {
                        datas[i] = new SearchData();
                        datas[i].first_index = first_index;
                        datas[i].second_index = second_index;
                        datas[i].str = data.str;
                        datas[i].numberOfColumn = data.numberOfColumn;
                        datas[i].RegistrON = data.RegistrON;
                        datas[i].UseWordWhole = data.UseWordWhole;
                        first_index += step;
                        second_index += step;
                    }
                    if (first_index < dataGrid.RowCount)
                    {
                        data.first_index = first_index;
                        data.second_index = dataGrid.RowCount;
                        search.ThreadSearch(data, dataGrid, descriptor);
                    }
                    for (int i = 0; i < datas.Length - 1; i++) search.ThreadSearch(datas[i], dataGrid, descriptor);
                    await search.ThreadSearch(datas[datas.Length - 1], dataGrid, descriptor);
                }
                else
                {
                    await search.ThreadSearch(data, dataGrid, descriptor);
                }
                cont:
                int result = resultsOfSearch;
                resultsOfSearch = 0;
                return result;
            });
        }
        public int StartSearch(SearchData inf, DataGridView dataGrid)
        {
            int flag = 0;
            string str = inf.str;
            int countOfResults = 0;
            string buf_str;
            if (inf.RegistrON)
            {
                if (inf.UseWordWhole)
                {
                    string[] str_words = str.Split(' ');
                    string[] buf_words;
                    if (inf.numberOfColumn == 5)
                    {
                        for (int i = inf.first_index; i < inf.second_index; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                buf_words = dataGrid.Rows[i].Cells[j].Value.ToString().Split(' ');
                                if (buf_words.Length == str_words.Length)
                                {
                                    for (int indx = 0; indx < str_words.Length; indx++)
                                    {
                                        if (str_words[indx] != buf_words[indx])
                                        {
                                            goto lalala;
                                        }
                                    }
                                    flag++;
                                    j = 3;
                                    break;
                                }
                                if (buf_words.Length < str_words.Length)
                                {
                                    continue;
                                }
                                for (int indx = 0; indx < buf_words.Length - str_words.Length + 1; indx++)
                                {
                                    if (buf_words[indx] == str_words[0])
                                    {
                                        for (int I = 0; I < str_words.Length; I++)
                                        {
                                            if (str_words[I] != buf_words[indx + I])
                                            {
                                                goto сontinue;
                                            }
                                        }
                                        flag++;
                                        j = 3;
                                    }
                                    break;
                                    сontinue:;
                                }
                                lalala:;
                            }
                            if (flag == 0)
                            {
                                dataGrid.Rows[i].Visible = false;
                                continue;
                            }
                            else
                            {
                                countOfResults++;
                                flag = 0;
                            }
                        }
                    }
                    else
                    {
                        for (int i = inf.first_index; i < inf.second_index; i++)
                        {
                            buf_words = dataGrid.Rows[i].Cells[inf.numberOfColumn].Value.ToString().Split(' ');
                            if (buf_words.Length == str_words.Length)
                            {
                                for (int indx = 0; indx < str_words.Length; indx++)
                                {
                                    if (str_words[indx] != buf_words[indx])
                                    {
                                        dataGrid.Rows[i].Visible = false;
                                        goto lalala;
                                    }
                                }
                                countOfResults++;
                                continue;
                            }
                            if (buf_words.Length < str_words.Length)
                            {
                                dataGrid.Rows[i].Visible = false;
                                continue;
                            }

                            for (int indx = 0; indx < buf_words.Length - str_words.Length + 1; indx++)
                            {
                                if (buf_words[indx] == str_words[0])
                                {
                                    for (int I = 0; I < str_words.Length; I++)
                                    {
                                        if (str_words[I] != buf_words[indx + I])
                                        {
                                            goto сontinue;
                                        }
                                    }
                                    flag++;
                                    countOfResults++;
                                    goto Break;
                                }
                                сontinue:;
                            }
                            Break:
                            if (flag == 0)
                            {
                                dataGrid.Rows[i].Visible = false;
                            }
                            flag = 0;
                            lalala:;
                        }

                    }
                }
                else
                {
                    string bufferWord = null;
                    if (inf.numberOfColumn == 5)
                    {
                        for (int i = inf.first_index; i < inf.second_index; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                bufferWord = dataGrid.Rows[i].Cells[j].Value.ToString();
                                if (bufferWord.Length < str.Length) continue;
                                if (!bufferWord.Contains(str)) continue;
                                flag++;
                                countOfResults++;
                                break;
                            }
                            if (flag == 0)
                                dataGrid.Rows[i].Visible = false;
                            flag = 0;
                        }
                    }
                    else
                    {
                        for (int i = inf.first_index; i < inf.second_index; i++)
                        {
                            bufferWord = dataGrid.Rows[i].Cells[inf.numberOfColumn].Value.ToString();
                            if (bufferWord.Length < str.Length)
                            {
                                dataGrid.Rows[i].Visible = false;
                                continue;
                            }
                            if (!bufferWord.Contains(str))
                            {
                                dataGrid.Rows[i].Visible = false;
                                continue;
                            }
                            countOfResults++;
                        }

                    }
                }
            }
            else
            {
                string bufferWord = null;
                str = str.ToLower(); // и так со всеми строками
                if (inf.UseWordWhole)
                {
                    string[] str_words = str.Split(' ');
                    string[] buf_words;
                    if (inf.numberOfColumn == 5)
                    {
                        for (int i = inf.first_index; i < inf.second_index; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                buf_words = dataGrid.Rows[i].Cells[j].Value.ToString().ToLower().Split(' ');
                                if (buf_words.Length == str_words.Length)
                                {
                                    for (int indx = 0; indx < str_words.Length; indx++)
                                    {
                                        if (str_words[indx] != buf_words[indx])
                                        {
                                            goto lalala;
                                        }
                                    }
                                    flag++;
                                    j = 3;
                                    break;
                                }
                                if (buf_words.Length < str_words.Length)
                                {
                                    continue;
                                }
                                for (int indx = 0; indx < buf_words.Length - str_words.Length + 1; indx++)
                                {
                                    if (buf_words[indx] == str_words[0])
                                    {
                                        for (int I = 0; I < str_words.Length; I++)
                                        {
                                            if (str_words[I] != buf_words[indx + I])
                                            {
                                                goto сontinue;
                                            }
                                        }
                                        flag++;
                                        j = 3;
                                    }
                                    goto Break;
                                    сontinue:;
                                }
                                lalala:;
                            }
                            Break:
                            if (flag == 0)
                            {
                                dataGrid.Rows[i].Visible = false;
                                continue;
                            }
                            else
                            {
                                countOfResults++;
                                flag = 0;
                            }
                        }
                    }
                    else
                    {
                        if (inf.numberOfColumn != 2)
                        {
                            for (int i = inf.first_index; i < inf.second_index; i++)
                            {
                                buf_words = dataGrid.Rows[i].Cells[inf.numberOfColumn].Value.ToString().ToLower().Split(' ');
                                if (buf_words.Length == str_words.Length)
                                {
                                    for (int indx = 0; indx < str_words.Length; indx++)
                                    {
                                        if (str_words[indx] != buf_words[indx])
                                        {
                                            dataGrid.Rows[i].Visible = false;
                                            goto lalala;
                                        }
                                    }
                                    countOfResults++;
                                    continue;
                                }
                                if (buf_words.Length < str_words.Length)
                                {
                                    dataGrid.Rows[i].Visible = false;
                                    continue;
                                }

                                for (int indx = 0; indx < buf_words.Length - str_words.Length + 1; indx++)
                                {
                                    if (buf_words[indx] == str_words[0])
                                    {
                                        for (int I = 0; I < str_words.Length; I++)
                                        {
                                            if (str_words[I] != buf_words[indx + I])
                                            {
                                                goto сontinue;
                                            }
                                        }
                                        flag++;
                                        countOfResults++;

                                    }
                                    break;
                                    сontinue:;
                                }
                                if (flag == 0)
                                    dataGrid.Rows[i].Visible = false;
                                flag = 0;
                                lalala:;
                            }
                        }
                        else
                        {
                            for (int i = inf.first_index; i < inf.second_index; i++)
                            {
                                bufferWord = dataGrid.Rows[i].Cells[2].Value.ToString().ToLower();
                                if (bufferWord != str)
                                    dataGrid.Rows[i].Visible = false;
                                else
                                    countOfResults++;
                            }
                        }
                    }
                }
                else
                {
                    if (inf.numberOfColumn == 5)
                    {
                        for (int i = inf.first_index; i < inf.second_index; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                bufferWord = dataGrid.Rows[i].Cells[j].Value.ToString().ToLower();
                                if (bufferWord.Length < str.Length) continue;
                                if (!bufferWord.Contains(str)) continue;
                                flag++;
                                countOfResults++;
                                break;
                            }
                            if (str == dataGrid.Rows[i].Cells[2].Value.ToString()) flag++;
                            if (flag == 0)
                                dataGrid.Rows[i].Visible = false;
                            else
                                flag = 0;
                        }
                    }
                    else
                    {
                        if (inf.numberOfColumn != 2)
                        {
                            for (int i = inf.first_index; i < inf.second_index; i++)
                            {
                                bufferWord = dataGrid.Rows[i].Cells[inf.numberOfColumn].Value.ToString().ToLower();
                                if (bufferWord.Length < str.Length)
                                {
                                    dataGrid.Rows[i].Visible = false;
                                    continue;
                                }
                                if (!bufferWord.Contains(str))
                                {
                                    dataGrid.Rows[i].Visible = false;
                                    continue;
                                }
                                countOfResults++;
                            }
                        }
                        else
                        {
                            for (int i = inf.first_index; i < inf.second_index; i++)
                            {
                                bufferWord = dataGrid.Rows[i].Cells[2].Value.ToString();
                                if (bufferWord != str)
                                {
                                    dataGrid.Rows[i].Visible = false;
                                    continue;
                                }
                                countOfResults++;
                            }
                        }
                    }
                }
            }
            return countOfResults;
        }
    }
    class Searcher
    {
        SearchData inf;
        public delegate void SearchEnd(int nubmer);
        public event SearchEnd taskEnded;
        public Task ThreadSearch(SearchData inf, DataGridView dataGrid, Form descriptor)
        {
            return Task.Factory.StartNew(() => {
                int flag = 0;
                string str = inf.str;
                int countOfResults = 0;
                string buf_str;
                if (inf.RegistrON)
                {
                    if (inf.UseWordWhole)
                    {
                        string[] str_words = str.Split(' ');
                        string[] buf_words;
                        if (inf.numberOfColumn == 5)
                        {
                            for (int i = inf.first_index; i < inf.second_index; i++)
                            {
                                for (int j = 0; j < 3; j++)
                                {
                                    buf_words = dataGrid.Rows[i].Cells[j].Value.ToString().Split(' ');
                                    if (buf_words.Length == str_words.Length)
                                    {
                                        for (int indx = 0; indx < str_words.Length; indx++)
                                        {
                                            if (str_words[indx] != buf_words[indx])
                                            {
                                                goto lalala;
                                            }
                                        }
                                        flag++;
                                        j = 3;
                                        break;
                                    }
                                    if (buf_words.Length < str_words.Length)
                                    {
                                        continue;
                                    }
                                    for (int indx = 0; indx < buf_words.Length - str_words.Length + 1; indx++)
                                    {
                                        if (buf_words[indx] == str_words[0])
                                        {
                                            for (int I = 0; I < str_words.Length; I++)
                                            {
                                                if (str_words[I] != buf_words[indx + I])
                                                {
                                                    goto сontinue;
                                                }
                                            }
                                            flag++;
                                            j = 3;
                                        }
                                        break;
                                        сontinue:;
                                    }
                                    lalala:;
                                }
                                if (flag == 0)
                                {
                                    descriptor.Invoke((Action)delegate { dataGrid.Rows[i].Visible = false; });
                                    continue;
                                }
                                else
                                {
                                    countOfResults++;
                                    flag = 0;
                                }
                            }
                        }
                        else
                        {
                            for (int i = inf.first_index; i < inf.second_index; i++)
                            {
                                buf_words = dataGrid.Rows[i].Cells[inf.numberOfColumn].Value.ToString().Split(' ');
                                if (buf_words.Length == str_words.Length)
                                {
                                    for (int indx = 0; indx < str_words.Length; indx++)
                                    {
                                        if (str_words[indx] != buf_words[indx])
                                        {
                                            descriptor.Invoke((Action)delegate { dataGrid.Rows[i].Visible = false; });
                                            goto lalala;
                                        }
                                    }
                                    countOfResults++;
                                    continue;
                                }
                                if (buf_words.Length < str_words.Length)
                                {
                                    descriptor.Invoke((Action)delegate { dataGrid.Rows[i].Visible = false; });
                                    continue;
                                }

                                for (int indx = 0; indx < buf_words.Length - str_words.Length + 1; indx++)
                                {
                                    if (buf_words[indx] == str_words[0])
                                    {
                                        for (int I = 0; I < str_words.Length; I++)
                                        {
                                            if (str_words[I] != buf_words[indx + I])
                                            {
                                                goto сontinue;
                                            }
                                        }
                                        flag++;
                                        countOfResults++;
                                        goto Break;
                                    }
                                    сontinue:;
                                }
                                Break:
                                if (flag == 0)
                                {
                                    descriptor.Invoke((Action)delegate { dataGrid.Rows[i].Visible = false; });
                                }
                                flag = 0;
                                lalala:;
                            }

                        }
                    }
                    else
                    {
                        string bufferWord = null;
                        if (inf.numberOfColumn == 5)
                        {
                            for (int i = inf.first_index; i < inf.second_index; i++)
                            {
                                for (int j = 0; j < 3; j++)
                                {
                                    bufferWord = dataGrid.Rows[i].Cells[j].Value.ToString();
                                    if (bufferWord.Length < str.Length) continue;
                                    if (!bufferWord.Contains(str)) continue;
                                    flag++;
                                    countOfResults++;
                                    break;
                                }
                                if (flag == 0)
                                    descriptor.Invoke((Action)delegate { dataGrid.Rows[i].Visible = false; });
                                flag = 0;
                            }
                        }
                        else
                        {
                            for (int i = inf.first_index; i < inf.second_index; i++)
                            {
                                bufferWord = dataGrid.Rows[i].Cells[inf.numberOfColumn].Value.ToString();
                                if (bufferWord.Length < str.Length)
                                {
                                    descriptor.Invoke((Action)delegate { dataGrid.Rows[i].Visible = false; });
                                    continue;
                                }
                                if (!bufferWord.Contains(str))
                                {
                                    descriptor.Invoke((Action)delegate { dataGrid.Rows[i].Visible = false; });
                                    continue;
                                }
                                countOfResults++;
                            }

                        }
                    }
                }
                else
                {
                    string bufferWord = null;
                    str = str.ToLower(); // и так со всеми строками
                    if (inf.UseWordWhole)
                    {
                        string[] str_words = str.Split(' ');
                        string[] buf_words;
                        if (inf.numberOfColumn == 5)
                        {
                            for (int i = inf.first_index; i < inf.second_index; i++)
                            {
                                for (int j = 0; j < 3; j++)
                                {
                                    buf_words = dataGrid.Rows[i].Cells[j].Value.ToString().ToLower().Split(' ');
                                    if (buf_words.Length == str_words.Length)
                                    {
                                        for (int indx = 0; indx < str_words.Length; indx++)
                                        {
                                            if (str_words[indx] != buf_words[indx])
                                            {
                                                goto lalala;
                                            }
                                        }
                                        flag++;
                                        j = 3;
                                        break;
                                    }
                                    if (buf_words.Length < str_words.Length)
                                    {
                                        continue;
                                    }
                                    for (int indx = 0; indx < buf_words.Length - str_words.Length + 1; indx++)
                                    {
                                        if (buf_words[indx] == str_words[0])
                                        {
                                            for (int I = 0; I < str_words.Length; I++)
                                            {
                                                if (str_words[I] != buf_words[indx + I])
                                                {
                                                    goto сontinue;
                                                }
                                            }
                                            flag++;
                                            j = 3;
                                        }
                                        goto Break;
                                        сontinue:;
                                    }
                                    lalala:;
                                }
                                Break:
                                if (flag == 0)
                                {
                                    descriptor.Invoke((Action)delegate { dataGrid.Rows[i].Visible = false; });
                                    continue;
                                }
                                else
                                {
                                    countOfResults++;
                                    flag = 0;
                                }
                            }
                        }
                        else
                        {
                            if (inf.numberOfColumn != 2)
                            {
                                for (int i = inf.first_index; i < inf.second_index; i++)
                                {
                                    buf_words = dataGrid.Rows[i].Cells[inf.numberOfColumn].Value.ToString().ToLower().Split(' ');
                                    if (buf_words.Length == str_words.Length)
                                    {
                                        for (int indx = 0; indx < str_words.Length; indx++)
                                        {
                                            if (str_words[indx] != buf_words[indx])
                                            {
                                                descriptor.Invoke((Action)delegate { dataGrid.Rows[i].Visible = false; });
                                                goto lalala;
                                            }
                                        }
                                        countOfResults++;
                                        continue;
                                    }
                                    if (buf_words.Length < str_words.Length)
                                    {
                                        descriptor.Invoke((Action)delegate { dataGrid.Rows[i].Visible = false; });
                                        continue;
                                    }

                                    for (int indx = 0; indx < buf_words.Length - str_words.Length + 1; indx++)
                                    {
                                        if (buf_words[indx] == str_words[0])
                                        {
                                            for (int I = 0; I < str_words.Length; I++)
                                            {
                                                if (str_words[I] != buf_words[indx + I])
                                                {
                                                    goto сontinue;
                                                }
                                            }
                                            flag++;
                                            countOfResults++;

                                        }
                                        break;
                                        сontinue:;
                                    }
                                    if (flag == 0)
                                        descriptor.Invoke((Action)delegate { dataGrid.Rows[i].Visible = false; });
                                    flag = 0;
                                    lalala:;
                                }
                            }
                            else
                            {
                                for (int i = inf.first_index; i < inf.second_index; i++)
                                {
                                    bufferWord = dataGrid.Rows[i].Cells[2].Value.ToString().ToLower();
                                    if (bufferWord != str)
                                        descriptor.Invoke((Action)delegate { dataGrid.Rows[i].Visible = false; });
                                    else
                                        countOfResults++;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (inf.numberOfColumn == 5)
                        {
                            for (int i = inf.first_index; i < inf.second_index; i++)
                            {
                                for (int j = 0; j < 2; j++)
                                {
                                    bufferWord = dataGrid.Rows[i].Cells[j].Value.ToString().ToLower();
                                    if (bufferWord.Length < str.Length) continue;
                                    if (!bufferWord.Contains(str)) continue;
                                    flag++;
                                    countOfResults++;
                                    break;
                                }
                                if (str == dataGrid.Rows[i].Cells[2].Value.ToString()) flag++;
                                if (flag == 0)
                                    descriptor.Invoke((Action)delegate { dataGrid.Rows[i].Visible = false; });
                                else
                                    flag = 0;
                            }
                        }
                        else
                        {
                            if (inf.numberOfColumn != 2)
                            {
                                for (int i = inf.first_index; i < inf.second_index; i++)
                                {
                                    bufferWord = dataGrid.Rows[i].Cells[inf.numberOfColumn].Value.ToString().ToLower();
                                    if (bufferWord.Length < str.Length)
                                    {
                                        descriptor.Invoke((Action)delegate { dataGrid.Rows[i].Visible = false; });
                                        continue;
                                    }
                                    if (!bufferWord.Contains(str))
                                    {
                                        descriptor.Invoke((Action)delegate { dataGrid.Rows[i].Visible = false; });
                                        continue;
                                    }
                                    countOfResults++;
                                }
                            }
                            else
                            {
                                for (int i = inf.first_index; i < inf.second_index; i++)
                                {
                                    bufferWord = dataGrid.Rows[i].Cells[2].Value.ToString();
                                    if (bufferWord != str)
                                    {
                                        descriptor.Invoke((Action)delegate { dataGrid.Rows[i].Visible = false; });
                                        continue;
                                    }
                                    countOfResults++;
                                }
                            }
                        }
                    }
                }
                taskEnded(countOfResults);
            });
        }
    }
}