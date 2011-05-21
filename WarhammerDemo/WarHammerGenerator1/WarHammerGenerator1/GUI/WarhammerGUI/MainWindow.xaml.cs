using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using Listen;
using System.Diagnostics;
using Common;

namespace WarhammerGUI
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            updateArmeeListenBox();
        }

        private void klickNeueStreitmacht(object sender, RoutedEventArgs e)
        {
            StreitmachtCreate streitmachtErzeugenFenster = new StreitmachtCreate(this);
            streitmachtErzeugenFenster.Owner = this;
            streitmachtErzeugenFenster.ShowDialog();

            updateGUI();
        }

        private void klickNeueStreitmachtMenu(object sender, RoutedEventArgs e)
        {
            StreitmachtCreate streitmachtErzeugenFenster = new StreitmachtCreate(this);
            streitmachtErzeugenFenster.ShowDialog();
            updateGUI();
        }


        private void klickQuitMenu(object sender, RoutedEventArgs e)
        {
            // Zunächst stellen wir eine Sicherheitsabfrage:
            string message = "Soll Army Bench wirklich beendet werden? Nicht gespeicherte Armeen gehen verloren!";
            string caption = "Sicherheitsabfrage";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = System.Windows.Forms.MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }

        }


        /// <summary>
        /// Löscht eine in der GUI ausgewählte Streitmacht!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void klickLoescheStreitMacht(object sender, RoutedEventArgs e)
        {
            int selectionIndex = ListBoxArmeeListe.SelectedIndex;

            // Wir zeigen natürlich nur dann etwas an, wenn auch etwas ausgewählt ist! :)
            if (selectionIndex != -1)
            {
                // Zunächst stellen wir eine Sicherheitsabfrage:
                string message = "Soll die ausgewählte Armee wirklich und endgültig gelöscht werden?";
                string caption = "Sicherheitsabfrage";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = System.Windows.Forms.MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    // Dann löschen wir. Wir wissen ja, dass der Name eindeutig ist!
                    spielerArmeeListe.getInstance().armeeSammlung.RemoveAt(selectionIndex);
                    // Refresh des Displays:
                    updateArmeeListenBox();

                    // Außerdem setzen wir den Selection Index nun um eins zurück:
                    ListBoxArmeeListe.SelectedIndex = selectionIndex - 1;
                }

                // Sonst passiert nichts!
            }
            updateGUI();
        }


        // Abhängig davon, welche Armee gerade aus der Liste selektiert worden ist, muss ich
        // natürlich noch dafür sorgen, dass die entsprechenden Haupteigenschaften im Fenster
        // ausgelesen und angezeigt werden!
        // Dazu muss ich erst einmal wissen, welches Item ausgewählt wurde!
        private void selektionInGUIGeandertEvent(object sender, SelectionChangedEventArgs e)
        {
            updateGUI();
        }

        /// <summary>
        /// Aktualisiert die GUI-Anzeige der Armee-Liste!
        /// </summary>
        public void updateArmeeListenBox()
        {
            // Zunächst mal müssen die alten Einträge natürlich weg:
            ListBoxArmeeListe.Items.Clear();

            // Jetzt muss ich die Sachen auch noch anzeigen:
            for (int i = 0; i < spielerArmeeListe.getInstance().armeeSammlung.Count; ++i)
            {
                ListBoxArmeeListe.Items.Add(spielerArmeeListe.getInstance().armeeSammlung[i].armeeName);
            }
            updateGUI();
        }


        /// <summary>
        /// Gibt einer Streitmacht einen neuen Namen!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void klickStreitmachtUmbennnen(object sender, RoutedEventArgs e)
        {
            int selectionIndex = ListBoxArmeeListe.SelectedIndex;

            if (selectionIndex != -1)
            {
                StreitmachtRename streitmachtRenameFenster = new StreitmachtRename(this, selectionIndex);
                streitmachtRenameFenster.Owner = this;
                streitmachtRenameFenster.ShowDialog();
            }
            updateGUI();
        }

        /// <summary>
        /// Kopiert eine bereite vorhandene Streitmacht
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void klickStreitmachtKopieren(object sender, RoutedEventArgs e)
        {
            int selectionIndex = ListBoxArmeeListe.SelectedIndex;

            if (selectionIndex != -1)
            {
                var blaupauseArmee = spielerArmeeListe.getInstance().armeeSammlung[selectionIndex];
                spielerArmeeKlasse neueArmee = new spielerArmeeKlasse(blaupauseArmee);
                neueArmee.armeeName = "Kopie von " + neueArmee.armeeName;
                spielerArmeeListe.getInstance().armeeSammlung.Add(neueArmee);
                updateArmeeListenBox();
            }
            updateGUI();
        }

        /// <summary>
        /// Speichert eine Armeeliste in ein XML-Dokument
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void klickStreitmachtListeSpeichern(object sender, RoutedEventArgs e)
        {
            armeeListeAbspeichern(false);
        }


        /// <summary>
        /// Speichert eine Armeeliste unter einem angegebenen Pfad in ein XML-Dokument
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void klickStreitmachtListeSpeichernUnter(object sender, RoutedEventArgs e)
        {
            armeeListeAbspeichern(true);
        }


        /// <summary>
        /// Kümmert sich um das Abspeichern von Armee-Listen.
        /// </summary>
        /// <param name="neuerPfadGewuenscht"></param>
        private void armeeListeAbspeichern(bool neuerPfadGewuenscht)
        {
            // Schauen wir zunächst einmal, ob wir schon einen alten Pfad haben, 
            // falls wir unter einem alten Pfad speichern wollen:
            var savePath = "";
            if (spielerArmeeListe.getInstance().saveString != "" && !neuerPfadGewuenscht)
            {
                savePath = spielerArmeeListe.getInstance().saveString;
            }
            else
            {
                // In diesem Fall müssen wir den Dialog anzeigen, um einen validen Pfad zu erhalten:
                // Dialog anzeigen:
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Armee-Liste|*.armylist";
                saveFileDialog1.Title = "Bitte eine Datei auswählen, um die Armee-Liste speichern!";
                saveFileDialog1.ShowDialog();
                savePath = saveFileDialog1.FileName;
            }

            // Wenn der Nutzer einen validen Pfad angegeben hat, geht's weiter:
            if (savePath != "")
            {
                XmlSerializer ser = new XmlSerializer(typeof(spielerArmeeListe));
                FileStream str = new FileStream(@savePath, FileMode.Create);
                ser.Serialize(str, spielerArmeeListe.getInstance());
                str.Close();
                // Außerdem wollen wir uns merken, wo die Armeeliste gespeichert wurde!
                spielerArmeeListe.getInstance().saveString = savePath;
            }
        }

        /// <summary>
        /// Exportiert eine einzelne Streitmacht in eine .army-Datei!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void klickStreitmachtExportieren(object sender, RoutedEventArgs e)
        {
            // Zunächst müssen wir prüfen, welche Armee der Nutzer ausgewählt hat:
            int selectionIndex = ListBoxArmeeListe.SelectedIndex;

            // Nur, wenn wirklich selektiert wurde, speichern wir auch ab:
            if (selectionIndex != -1)
            {
                // Wir rufen immer den Export-Dialog extra auf!
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Armee|*.army";
                saveFileDialog1.Title = "Bitte eine Datei auswählen, um die Armee zu exportieren!";
                saveFileDialog1.ShowDialog();
                var savePath = saveFileDialog1.FileName;

                XmlSerializer ser = new XmlSerializer(typeof(spielerArmeeKlasse));
                FileStream str = new FileStream(@savePath, FileMode.Create);
                ser.Serialize(str, spielerArmeeListe.getInstance().armeeSammlung[selectionIndex]);
                str.Close();
            }
        }

        /// <summary>
        /// Importiert eine einzelne Streitmacht in die aktuelle Streitmacht-Liste:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void klickStreitmachtImportieren(object sender, RoutedEventArgs e)
        {
            // Lassen wir den Spieler zunächst auswählen, wo er die Armee hat:
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Army-Datei (*.army)|*.army";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            XmlSerializer ser = new XmlSerializer(typeof(spielerArmeeKlasse));
                            StreamReader sr = new StreamReader(myStream);
                            spielerArmeeKlasse zuImportierendeKlasse = (spielerArmeeKlasse)ser.Deserialize(sr);
                            sr.Close();
                            // Bevor wir die Armee intragen können, müssen wir sicherstellen, dass der Name nicht
                            // bereits vergeben ist!
                            var allesOkay = true;
                            var nameDerZuImportierendenArmee = zuImportierendeKlasse.armeeName;
                            for (int i = 0; i < spielerArmeeListe.getInstance().armeeSammlung.Count; ++i)
                                if (spielerArmeeListe.getInstance().armeeSammlung[i].armeeName == nameDerZuImportierendenArmee)
                                {
                                    System.Windows.MessageBox.Show("Es ist bereits eine Armee mit diesem Namen vorhanden!", "Kann Armee nicht importieren!", MessageBoxButton.OK, MessageBoxImage.Error);
                                    allesOkay = false;
                                }

                            if (allesOkay)
                            {
                                // Jetzt trage ich die Armee auch in die Liste ein:
                                var alteArmeeAnzahl = spielerArmeeListe.getInstance().armeeSammlung.Count;
                                // Und natürlich schreiben wir diese auch gleich in unsere globale Armee-Liste!
                                spielerArmeeListe.getInstance().armeeSammlung.Add(zuImportierendeKlasse);

                                // Außerdem wollen wir, dass die Anzeige-Box des Hauptfensters aktualisiert wird!
                                updateArmeeListenBox();

                                // Und wir möchten gerne die neu erstelle Armee ausgewählt haben!
                                ListBoxArmeeListe.SelectedIndex = alteArmeeAnzahl;
                            }
                            // Wenn der Name nicht eindeutig war, passiert nichts!
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show("Fehler: Konnte die Armee nicht einlesen! Fehlermeldung: " + ex.Message);
                }
            }
            updateGUI();
        }

        /// <summary>
        /// Öffnet eine vorhandene Streitmachtliste!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void klickStreitmachtlisteOeffnen(object sender, RoutedEventArgs e)
        {
            bool wirklichOeffnen = true;
            // Falls es bereits eine nicht leere Armeeliste gibt, müssen wir den User fragen, ob er
            // diese wirklich überschreiben möchte!
            if (spielerArmeeListe.getInstance().armeeSammlung.Count != 0)
            {
                string message = "Soll wirklich eine Armeeliste geladen werden? Die aktuelle Armeeliste wird dann überschrieben und nicht gespeicherte Armeen gehen verloren!";
                string caption = "Sicherheitsabfrage";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = System.Windows.Forms.MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                    wirklichOeffnen = true;
                else
                    wirklichOeffnen = false;
            }

            // Wenn der Nutzer das nicht möchte, machen wir natürlich nichts!
            if(wirklichOeffnen)
            {
                // Okay, welche soll denn importiert werden?
                // Lassen wir den Spieler zunächst auswählen, wo er die Armee hat:
                Stream myStream = null;
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.Filter = "Armylist-Datei (*.armylist)|*.armylist";
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        if ((myStream = openFileDialog1.OpenFile()) != null)
                        {
                            using (myStream)
                            {
                                XmlSerializer ser = new XmlSerializer(typeof(spielerArmeeListe));
                                StreamReader sr = new StreamReader(myStream);
                                var zuImportierendeListe = (spielerArmeeListe)ser.Deserialize(sr);
                                sr.Close();

                                // Jetzt müssen wir von Hand das Singleton aktualisieren!
                                spielerArmeeListe.getInstance().eraseMeTotally();
                                spielerArmeeListe.getInstance().saveString = myStream.ToString();
                                spielerArmeeListe.getInstance().armeeSammlung = zuImportierendeListe.armeeSammlung;

                                // Außerdem wollen wir, dass die Anzeige-Box des Hauptfensters aktualisiert wird!
                                updateArmeeListenBox();

                                // Und wir selektieren den ersten Index!
                                if(spielerArmeeListe.getInstance().armeeSammlung.Count != 0)
                                    ListBoxArmeeListe.SelectedIndex = 0;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Windows.MessageBox.Show("Fehler: Konnte die Armee nicht einlesen! Fehlermeldung: " + ex.Message);
                    }
                }
            }

            updateGUI();
        }

        /// <summary>
        /// Ermöglicht es, eine ausgewählte Streitmacht zu bearbeiten!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void klickStreitmachtBearbeiten(object sender, RoutedEventArgs e)
        {
            // Wir können nur etwas bearbeiten, wenn auch etwas ausgewählt wurde! :)
            if (ListBoxArmeeListe.SelectedIndex != -1)
            {
                // Wenn das der Fall ist, öffnen wir ein neues Fenster, in dem wir die Details der Streitmacht darstellen können!
                StreitmachtEdit streitmachtEditFenster = new StreitmachtEdit(this, ListBoxArmeeListe.SelectedIndex);
                streitmachtEditFenster.Owner = this;
                streitmachtEditFenster.ShowDialog();
            }

            updateGUI();
        }


        private void updateGUI()
        {
            int selectionIndex = ListBoxArmeeListe.SelectedIndex;

            // Wir zeigen natürlich nur dann etwas an, wenn auch etwas ausgewählt ist! :)
            if (selectionIndex != -1)
            {
                displayArmyName.Clear();
                string neuerName = spielerArmeeListe.getInstance().armeeSammlung[selectionIndex].armeeName;
                displayArmyName.AppendText(neuerName);

                string neueFraktion = spielerArmeeListe.getInstance().armeeSammlung[selectionIndex].armeeFraktion.ToString();
                displayArmySide.Clear();
                displayArmySide.AppendText(neueFraktion);

                string gesamtKosten = spielerArmeeListe.getInstance().armeeSammlung[selectionIndex].gesamtPunkte.ToString();
                displayArmyPoints.Clear();
                displayArmyPoints.AppendText(gesamtKosten);
            }
        }

        // Ich möchte, dass eine Übersicht der Streitmacht erstellt wird!
        private void onStreitMachtToTex(object sender, RoutedEventArgs e)
        {
            if (ListBoxArmeeListe.SelectedIndex == -1)
                return;

            // Bevor ich loslege, möchte ich wisen, in welcher Datei die Übersicht abgelegt werden soll!
            // Wir rufen immer den Export-Dialog extra auf!
            string savePath = "";
            string ordner = "";
            string dateiname = "";
            string dateiNameOhneEndung = "";

            bool allesOkay = false;
            while(!allesOkay)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Armeeübersicht|*.tex";
                saveFileDialog1.Title = "Bitte eine Datei auswählen, um die Armeeüberischt zu exportieren!";
                saveFileDialog1.ShowDialog();
                savePath = saveFileDialog1.FileName;

                if (savePath == "")
                    return;

                pruefeAufUmlaute checkObj = new pruefeAufUmlaute(){};
                if (!checkObj.enthaeltDerFolgendeStringUmlaute(savePath) && !checkObj.enthaeltDerFolgendeStringLeerzeichen(savePath))
                {
                    ordner = System.IO.Path.GetDirectoryName(saveFileDialog1.FileName);
                    dateiname = System.IO.Path.GetFileName(saveFileDialog1.FileName);
                    dateiNameOhneEndung = System.IO.Path.GetFileNameWithoutExtension(saveFileDialog1.FileName);
                    allesOkay = true;
                }
                else
                {
                    System.Windows.MessageBox.Show("Bitte keine Umlaute oder Leerzeichen im Dateinamen wählen!",
                        "Nicht erlaubte Zeichen im Dateinamen!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
                

            // Jetzt rufen wir unsere Unterklasse auf, die sich nur damit beschäftigt, die Armee auszugeben!
            armyToTex konverter = new armyToTex() { };
            konverter.generateTexFile(savePath, ListBoxArmeeListe.SelectedIndex);

            // So, damit existiert unsere .tex-Datei nun. Jetzt müssen wir sie nur noch kompilieren!
            // Bei einer Installation von LaTeX ist pdflatex.exe normalerweise immer als Pfadvariable eingetragen;
            // falls nicht, haben wir hier ein Problem!
            // TODO: Was mache ich dann???

            string pfadBatDatei = ordner + "\\" + "ErstelleArmeePDF" + ".bat";
            string pfadPDF = ordner + "\\" + dateiNameOhneEndung + ".pdf";

            FileStream str = new FileStream(pfadBatDatei, FileMode.Create);
            str.Close();
            StreamWriter sw = new StreamWriter(@pfadBatDatei, true, System.Text.Encoding.GetEncoding("ISO-8859-1"));
            sw.Write("cd " + ordner);
            sw.Write("\n");
            sw.Write("pdflatex.exe " + savePath);
            sw.Write("\n");
            sw.Write("pdflatex.exe " + savePath);
            sw.Write("\n");
            sw.Write("pdflatex.exe " + savePath);   // dreimal kompilieren, damit alles okay ist!
            sw.Write("\n");
            //sw.Write(pfadPDF);
            //sw.Write("\n");
            sw.Write("exit");
            sw.Close();
            // .bat ausführen!
            var meinProzess = new Process();
            var meineProzessInfo = new ProcessStartInfo(pfadBatDatei, "");
            meinProzess.StartInfo = meineProzessInfo;
            meinProzess.Start();
            meinProzess.WaitForExit();
            meinProzess.Close();
            meinProzess.Dispose();

            // Aufräumen und den ganzen nicht mehr benötigten Mist löschen!
            File.Delete(ordner + "\\" + dateiNameOhneEndung + ".aux");
            File.Delete(ordner + "\\" + dateiNameOhneEndung + ".toc");
            File.Delete(ordner + "\\" + dateiNameOhneEndung + ".log");
            File.Delete(ordner + "\\" + dateiNameOhneEndung + ".out");
            File.Delete(ordner + "\\" + "ErstelleArmeePDF" + ".bat");

            // Jetzt erst die PDF anzeigen:
            var anzeigePDF = new Process();
            meineProzessInfo = new ProcessStartInfo(pfadPDF, "");
            anzeigePDF.StartInfo = meineProzessInfo;
            anzeigePDF.Start();
            anzeigePDF.Close();
            anzeigePDF.Dispose();
        }

        /// <summary>
        /// Executes a shell command synchronously. From: http://www.codeproject.com/KB/cs/Execute_Command_in_CSharp.aspx
        /// </summary>
        /// <param name="command">string command</param>
        /// <returns>string, as output of the command.</returns>
        public void ExecuteCommandSync(object command)
        {
            try
            {
                // create the ProcessStartInfo using "cmd" as the program to be run,
                // and "/c " as the parameters.
                // Incidentally, /c tells cmd that we want it to execute the command that follows,
                // and then exit.
                System.Diagnostics.ProcessStartInfo procStartInfo =
                    new System.Diagnostics.ProcessStartInfo("cmd", "/c " + "pdflatex.exe C:\\Users\\Admin\\Desktop\\Test.tex");

                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                // Do not create the black window.
                procStartInfo.CreateNoWindow = false;
                // Now we create a process, assign its ProcessStartInfo and start it
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                // Get the output into a string
                string result = proc.StandardOutput.ReadToEnd();
                // Display the command output.
                Console.WriteLine(result);
            }
            catch (Exception objException)
            {
                throw new ArgumentException(objException.ToString());
            }
        }


        /// <summary>
        /// Execute a shell command
        /// </summary>
        /// <param name="_FileToExecute">File/Command to execute</param>
        /// <param name="_CommandLine">Command line parameters to pass</param> 
        /// <param name="_outputMessage">returned string value after executing shell command</param> 
        /// <param name="_errorMessage">Error messages generated during shell execution</param> 
        public string ExecuteShellCommand(string _FileToExecute, string _CommandLine)
        {

            string _outputMessage = "";
            string _errorMessage = "";

            // Set process variable
            // Provides access to local and remote processes and enables you to start and stop local system processes.
            System.Diagnostics.Process _Process = null;
            try
            {
                _Process = new System.Diagnostics.Process();

                // invokes the cmd process specifying the command to be executed.
                string _CMDProcess = string.Format(System.Globalization.CultureInfo.InvariantCulture, @"{0}\cmd.exe", new object[] { Environment.SystemDirectory });

                // pass executing file to cmd (Windows command interpreter) as a arguments
                // /C tells cmd that we want it to execute the command that follows, and then exit.
                string _Arguments = string.Format(System.Globalization.CultureInfo.InvariantCulture, "/C {0}", new object[] { _FileToExecute });

                // pass any command line parameters for execution
                if (_CommandLine != null && _CommandLine.Length > 0)
                {
                    _Arguments += string.Format(System.Globalization.CultureInfo.InvariantCulture, " {0}", new object[] { _CommandLine, System.Globalization.CultureInfo.InvariantCulture });
                }

                // Specifies a set of values used when starting a process.
                System.Diagnostics.ProcessStartInfo _ProcessStartInfo = new System.Diagnostics.ProcessStartInfo(_CMDProcess, _Arguments);
                // sets a value indicating not to start the process in a new window. 
                _ProcessStartInfo.CreateNoWindow = false;
                // sets a value indicating not to use the operating system shell to start the process. 
                _ProcessStartInfo.UseShellExecute = false;
                // sets a value that indicates the output/input/error of an application is written to the Process.
                _ProcessStartInfo.RedirectStandardOutput = true;
                _ProcessStartInfo.RedirectStandardInput = true;
                _ProcessStartInfo.RedirectStandardError = true;
                _Process.StartInfo = _ProcessStartInfo;

                // Starts a process resource and associates it with a Process component.
                _Process.Start();

                // Instructs the Process component to wait indefinitely for the associated process to exit.
                _errorMessage = _Process.StandardError.ReadToEnd();
                _Process.WaitForExit();

                // Instructs the Process component to wait indefinitely for the associated process to exit.
                _outputMessage = _Process.StandardOutput.ReadToEnd();
                _Process.WaitForExit();
            }
            catch (Exception _Exception)
            {
                // Error
                Console.WriteLine("Exception caught in process: {0}", _Exception.ToString());
            }
            finally
            {
                // close process and do cleanup
                _Process.Close();
                _Process.Dispose();
                _Process = null;
            }

            return _outputMessage;
        }


        public static int TestCom(string Command, int Timeout)
        {
            int ExitCode;
            System.Diagnostics.ProcessStartInfo ProcessInfo;
            var Process = new System.Diagnostics.Process();

            ProcessInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " + Command);
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = false;
            Process.StartInfo = ProcessInfo;
            Process.WaitForExit(Timeout);
            ExitCode = Process.ExitCode;
            Process.Close();

            return ExitCode;
        }
    }
}
