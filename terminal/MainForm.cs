/*
 * Erstellt mit SharpDevelop.
 * Benutzer: jdebernitz
 * Datum: 04.04.2016
 * Zeit: 10:00
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;

namespace terminal
{
   /// <summary>
   /// Description of MainForm.
   /// </summary>
   public partial class MainForm : Form
   {
      SerialPort serialPort;
      bool mIsConnected;
      
      char[] inputBuffer;
      
      ulong mRxCounter;
      ulong mTxCounter;
      
      public MainForm()
      {
         //
         // The InitializeComponent() call is required for Windows Forms designer support.
         //
         InitializeComponent();
         
         //
         // TODO: Add constructor code after the InitializeComponent() call.
         //
         mIsConnected = false;
         timer1.Enabled = true;
         
         inputBuffer = new char[250];
         mRxCounter = 0;
         mTxCounter = 0;
         
         readOutPortList();
         
         comboBoxBaud.SelectedIndex = 12;
         comboBoxData.SelectedIndex = 3;
         comboBoxStop.SelectedIndex = 1;
         comboBoxParity.SelectedIndex = 0;
         
         serialPort = new SerialPort();
      }
      void ExitToolStripMenuItemClick(object sender, EventArgs e)
      {
         if (serialPort.IsOpen)
         {
            serialPort.Close();
         }
         Close();
      }
      void Timer1Tick(object sender, EventArgs e)
      {
         toolStripStatusLabelTime.Text = DateTime.Now.ToLongTimeString();
      }
      void ButtonConnectClick(object sender, EventArgs e)
      {
         if (mIsConnected == true)
         {
            mIsConnected = false;
         }
         else
         {
            mIsConnected = true;
         }
         
         handleConnection();
      }
      
      void ButtonRefreshPortListClick(object sender, EventArgs e)
      {
         readOutPortList();
      }
      
      void readOutPortList()
      {
         
         comboBoxPort.Items.Clear();
         
         try
         {
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            // Display each port name to the console.

            for (int i = 0; i < ports.Length; i++)
            {
               string portName = ports[i];
               comboBoxPort.Items.Add(portName);
            }
            
            if(ports.Length >= 1)
            {
               comboBoxPort.SelectedIndex = 0;
            }


         }
         catch (UnauthorizedAccessException ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
      
      StopBits getStopBit()
      {
         StopBits returnValue;
         
         switch(comboBoxStop.SelectedIndex)
         {
            case 0:
               returnValue = StopBits.None;
               break;
            case 1:
               returnValue = StopBits.One;
               break;
            case 2:
               returnValue = StopBits.OnePointFive;
               break;
            case 3:
               returnValue = StopBits.Two;
               break;
            default:
               returnValue = StopBits.One;
               break;
         }
         
         return returnValue;
      }
      
      
      Parity getParity()
      {
         Parity returnValue;
         
         switch(comboBoxParity.SelectedIndex)
         {
            case 0:
               returnValue = Parity.None;
               break;
            case 1:
               returnValue = Parity.Even;
               break;
            case 2:
               returnValue = Parity.Odd;
               break;
            case 3:
               returnValue = Parity.Mark;
               break;
            case 4:
               returnValue = Parity.Space;
               break;
            default:
               returnValue = Parity.None;
               break;
         }
         
         return returnValue;
      }
      
      void handleConnection()
      {
         
         if (mIsConnected == true)
         {
            toolStripStatusLabelConnect.Text = "Connected";
            buttonConnect.Text = "Disconnect";
            
            try
            {
               int baudrate = Convert.ToInt32(comboBoxBaud.SelectedItem.ToString());
               
               serialPort.PortName = comboBoxPort.SelectedItem.ToString();
               serialPort.BaudRate = baudrate;
               serialPort.DataReceived += new SerialDataReceivedEventHandler(this.serialPort_DataReceived);
               serialPort.ReadBufferSize = 4096;
               serialPort.StopBits = getStopBit();
               serialPort.DataBits = Convert.ToInt32(comboBoxData.SelectedItem.ToString());
               serialPort.Parity = getParity();
               
               if (!serialPort.IsOpen)
               {
                  serialPort.Encoding = System.Text.Encoding.Default;
                  serialPort.Open();
               }
               
               if (!serialPort.IsOpen)
               {
                  mIsConnected = false;
                  toolStripStatusLabelConnect.Text = "Not connected";
                  buttonConnect.Text = "Connect";
                  serialPort.Close();
               }
               else
               {
                  comboBoxPort.Enabled = false;
                  comboBoxBaud.Enabled = false;
                  comboBoxData.Enabled = false;
                  comboBoxStop.Enabled = false;
                  comboBoxParity.Enabled = false;
               }
               
            }
            catch (UnauthorizedAccessException ex)
            {
               MessageBox.Show(ex.Message);
               mIsConnected = false;
               toolStripStatusLabelConnect.Text = "Not connected";
               buttonConnect.Text = "Connect";
               serialPort.Close();
            }
            
         }
         else
         {
            toolStripStatusLabelConnect.Text = "Not connected";
            buttonConnect.Text = "Connect";
            serialPort.Close();
         }
      }
      
            /*!
       * @brief data Received function for the input handler from the serial port
       * 
       * @param object sender
       * @param SerialDataReceivedEventArgs e
       */
      private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
      {
         try
         {
            mRxCounter += (ulong)serialPort.Read(inputBuffer, 0, inputBuffer.Length);
            
            this.Invoke(new EventHandler(displayText));
            Array.Clear(inputBuffer, 0, 250);
         }
         catch (System.TimeoutException)
         {
            MessageBox.Show("Time out Failure");
         }
         catch (System.ArgumentException)
         {
            MessageBox.Show("Argument Exception");
         }
         catch (System.Exception)
         {
            MessageBox.Show("Exception");
         }
      }

      /*!
       * @brief diplayed the message information from the serial port
       * 
       * @param obeject sender
       * @param EventArgs e
       */
      private void displayText(object sender, EventArgs e)
      {
         string s = new string(inputBuffer);
         textBox1.Text += s;
         
         textBoxRxCount.Text = mRxCounter.ToString();
      }
      void ButtonResetRxCountClick(object sender, EventArgs e)
      {
         mRxCounter = 0;
         textBoxRxCount.Text = mRxCounter.ToString();
      }
      void ButtonResetTxCountClick(object sender, EventArgs e)
      {
         mTxCounter = 0;
         textBoxTxCount.Text = mTxCounter.ToString();
      }

   }
}
