using MultiDictionarySystem.Data;
using MultiDictionarySystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MultiDictionarySystem.User
{
    public partial class MultiDictionaryUserForm : Form
    {
        private bool isDeutscheDbContentSelected = false;
        private bool isEnglishDbContentSelected = false;
        private MultiDictionaryEnglishDbContext englishData;
        private MultiDictionaryDeutscheDbContext deutscheData;
        private IDictionary<string, Word> tempEnglishData;
        private IDictionary<string, Word> tempDeutscheData;
        private SpeechSynthesizer speaker = new SpeechSynthesizer();
        private PromptBuilder cultures = new PromptBuilder();  

        public MultiDictionaryUserForm()
        {
            InitializeComponent();
            this.englishData = new MultiDictionaryEnglishDbContext();
            this.deutscheData = new MultiDictionaryDeutscheDbContext();
            this.tempEnglishData = GetDbContent("english");
            this.tempDeutscheData = GetDbContent("deutsche");
        }

        private IDictionary<string, Word> GetDbContent(string dbContentType)
        {
            IDictionary<string, Word> data = new SortedDictionary<string, Word>();

            if (dbContentType == "english")
            {
                foreach (Word word in this.englishData.EnglishWords)
                {
                    string toLower = word.Original.ToString().ToLower();

                    if (!data.ContainsKey(toLower))
                    {
                        data.Add(toLower, word);
                    }
                }
            }
            else if (dbContentType == "deutsche")
            {
                foreach (Word word in this.deutscheData.DeutscheWords)
                {
                    string toLower = word.Original.ToString().ToLower();

                    if (!data.ContainsKey(toLower))
                    {
                        data.Add(toLower, word);
                    }
                }
            }

            
            return data;
    }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TextMasseges.ABOUT);
        }

        private void loadGermanContentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.isDeutscheDbContentSelected = true;
            this.isEnglishDbContentSelected = false;
            this.count.Text = this.deutscheData.DeutscheWords.Count().ToString();

            ShowItems();
            ClearScreens();
        }

        private void loadEnglishContentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.isEnglishDbContentSelected = true;
            this.isDeutscheDbContentSelected = false;
            this.count.Text = this.englishData.EnglishWords.Count().ToString();

            ShowItems();
            ClearScreens();
        }

        private void originalWordsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.translatedWordsListBox.SelectedIndex = this.originalWordsListBox.SelectedIndex;
        }

        private void translatedWordsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.originalWordsListBox.SelectedIndex = this.translatedWordsListBox.SelectedIndex;
        }

        private void ShowItems()
        {
            foreach (Control control in this.Controls)
            {
                if (!control.Visible)
                {
                    control.Visible = true;
                }
            }
        }

        private void addToDbBtn_Click(object sender, EventArgs e)
        {
            if (this.newWordTxtBox.Text != string.Empty)
            {
                ClearScreens();
                StringBuilder word = new StringBuilder();
                word.Append(this.newWordTxtBox.Text);

                string[] originalTranslation;

                if (this.isEnglishDbContentSelected && word.ToString().Contains('-'))
                {
                    originalTranslation = word.ToString().Split('-');

                    if (!this.tempEnglishData.ContainsKey(originalTranslation[0]))
                    {
                        HashSet<Translation> translations = GetTranslations(originalTranslation[1]);

                        Word wordPlusTranslation = new Word();
                        wordPlusTranslation.Original = originalTranslation[0];
                        wordPlusTranslation.Translations = translations;

                        this.englishData.EnglishWords.Add(wordPlusTranslation);
                        this.englishData.SaveChanges();

                        this.tempEnglishData = GetDbContent("english");

                        this.count.Text = this.englishData.EnglishWords.Count().ToString();
                    }
                }
                else if(this.isDeutscheDbContentSelected && word.ToString().Contains('-'))
                {
                    originalTranslation = word.ToString().Split('-');

                    HashSet<Translation> translations = GetTranslations(originalTranslation[1]);

                    Word wordPlusTranslation = new Word();
                    wordPlusTranslation.Original = originalTranslation[0];
                    wordPlusTranslation.Translations = translations;

                    this.deutscheData.DeutscheWords.Add(wordPlusTranslation);
                    this.deutscheData.SaveChanges();

                    this.tempDeutscheData = GetDbContent("deutsche");

                    this.count.Text = this.deutscheData.DeutscheWords.Count().ToString();
                }
                else
                {
                    MessageBox.Show(TextMasseges.NOTCORRECTWORD);
                }

                this.newWordTxtBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(TextMasseges.EMPTY);
            }
        }

        private HashSet<Translation> GetTranslations(string words)
        {
            HashSet<Translation> translations = new HashSet<Translation>();

            string[] splited = words.Split(new char[] { ' ', ',' });

            foreach (string word in splited)
            {
                Translation tr = new Translation();
                tr.Translated = word;
                translations.Add(tr);
            }

            return translations;
        }

        private void removeFromDbBtn_Click(object sender, EventArgs e)
        {
            if (this.removeWordTxtBox.Text != string.Empty)
            {
                ClearScreens();

                try
                {
                    string wordToRemove = this.removeWordTxtBox.Text.ToString().ToLower();

                    if (this.isEnglishDbContentSelected)
                    {
                        Word toRemove = this.tempEnglishData[wordToRemove];
                        this.tempEnglishData.Remove(toRemove.Original);
                        this.englishData.EnglishWords.Remove(toRemove);
                        this.englishData.SaveChanges();

                        this.tempDeutscheData = GetDbContent("english");
                        this.count.Text = this.englishData.EnglishWords.Count().ToString();
                    }
                    else if (this.isDeutscheDbContentSelected)
                    {
                        Word toRemove = this.tempDeutscheData[wordToRemove];
                        this.tempDeutscheData.Remove(toRemove.Original);
                        this.deutscheData.DeutscheWords.Remove(toRemove);
                        this.deutscheData.SaveChanges();

                        this.tempDeutscheData = GetDbContent("deutsche");

                        this.count.Text = this.deutscheData.DeutscheWords.Count().ToString();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(TextMasseges.CANTREMOVE);
                }

                this.removeWordTxtBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(TextMasseges.EMPTY);
            }
        }

        private void howItSoundsBtn_Click(object sender, EventArgs e)
        {
            if (this.originalWordsListBox.SelectedItem != null)
            {
                this.cultures.ClearContent();
                
                if (this.isEnglishDbContentSelected)
                {
                    this.cultures.StartVoice(new System.Globalization.CultureInfo("en-US"));
                }
                else if (this.isDeutscheDbContentSelected)
                {
                    this.cultures.StartVoice(new System.Globalization.CultureInfo("de-DE"));
                }
                     
                this.cultures.AppendText(this.originalWordsListBox.SelectedItem.ToString());
                this.cultures.EndVoice();
                this.speaker.Speak(this.cultures);
            }
            else
            {
                MessageBox.Show(TextMasseges.SELECTITEM);
            }
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            ClearScreens();

            IDbSet<Word> words = null;

            if (this.isEnglishDbContentSelected)
            {
                var keys = this.tempEnglishData.Keys;

                PrintWords(keys, "en");
            }
            else if (this.isDeutscheDbContentSelected)
            {
                var keys = this.tempDeutscheData.Keys;

                PrintWords(keys, "de");
            }
        }

        private void PrintWords(ICollection<string> keys, string content)
        {
            IDictionary<string, Word> data = null;
            if (content == "en")
            {
                data = this.tempEnglishData;
            }
            else if (content == "de")
            {
                data = this.tempDeutscheData;
            }

            StringBuilder sb = new StringBuilder();

            foreach (string key in keys)
            {
                this.originalWordsListBox.Items.Add(key);
                var translations = data[key].Translations;

                foreach (Translation translation in translations)
                {
                    sb.Append(translation.Translated + ",");
                }

                if (sb.Length > 1)
                {
                    sb.Length--;
                }

                this.translatedWordsListBox.Items.Add(sb.ToString());
                sb.Clear();
            }  
        }

        private void ClearScreens()
        {
            this.originalWordsListBox.Items.Clear();
            this.translatedWordsListBox.Items.Clear();
        }

        private void KeyPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                addToDbBtn_Click(this, new EventArgs());
            }
        }

        private void HowItSoundsCall(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && this.originalWordsListBox.SelectedItem != null)
            {
                howItSoundsBtn_Click(this, new EventArgs());
            }
        }

        private void searchFromDbBtn_Click(object sender, EventArgs e)
        {
            if (this.searchWordTxtBox.Text != null)
            {
                ClearScreens();

                string searchedPiece = this.searchWordTxtBox.Text.ToString().ToLower();

                if (this.isEnglishDbContentSelected)
                {
                    var keys = this.tempEnglishData.Keys;

                    foreach (string key in keys)
                    {
                        if (searchedPiece.Length <= key.Length)
                        {
                            string pieceToCompare = key.Substring(0, searchedPiece.Length);

                            if (searchedPiece == pieceToCompare)
                            {
                                this.originalWordsListBox.Items.Add(key);
                                this.translatedWordsListBox.Items.Add(this.tempEnglishData[key].ToString());
                            }
                        }
                    }
                }
                else if (this.isDeutscheDbContentSelected)
                {
                    var keys = this.tempDeutscheData.Keys;

                    foreach (string key in keys)
                    {
                        if (searchedPiece.Length <= key.Length)
                        {
                            string pieceToCompare = key.Substring(0, searchedPiece.Length);

                            if (searchedPiece == pieceToCompare)
                            {
                                this.originalWordsListBox.Items.Add(key);
                                this.translatedWordsListBox.Items.Add(this.tempDeutscheData[key].ToString());
                            }


                        }
                    }
                }
            }
        }

        private void AutoSearch(object sender, EventArgs e)
        {
            searchFromDbBtn_Click(this, new EventArgs());
        }
    }
}
