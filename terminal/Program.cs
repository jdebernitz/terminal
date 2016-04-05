/*
 * Erstellt mit SharpDevelop.
 * Benutzer: jdebernitz
 * Datum: 04.04.2016
 * Zeit: 10:00
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Windows.Forms;

namespace terminal
{
   /// <summary>
   /// Class with program entry point.
   /// </summary>
   internal sealed class Program
   {
      /// <summary>
      /// Program entry point.
      /// </summary>
      [STAThread]
      private static void Main(string[] args)
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new MainForm());
      }
      
   }
}
