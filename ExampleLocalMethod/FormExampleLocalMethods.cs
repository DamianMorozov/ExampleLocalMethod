using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ExampleLocalMethod
{
    internal class ClassPerson : IDisposable
    {
        private bool Disposed { get; set; }

        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value ?? @"<empty>";
        }

        public ClassPerson(string name) => Name = name;

        ~ClassPerson() => Dispose();

        // Высвободить управляемые ресурсы
        private void DisposeManagedResources()
        {
        }

        // Высвободить неуправляемые ресурсы
        private void DisposeUnmanagedResources()
        {
        }

        private void CheckIfDisposed()
        {
            if (Disposed)
            {
                throw new ObjectDisposedException(@"Example: object has been disposed off!");
            }
        }

        public virtual void Dispose()
        {
            lock (this)
            {
                if (!Disposed)
                {
                    // Высвободить управляемые ресурсы
                    DisposeManagedResources();

                    // Высвободить неуправляемые ресурсы
                    DisposeUnmanagedResources();

                    // Флаг высвобождения ресурсов
                    Disposed = true;

                    // Log
                    Debug.Print(Name + @" - Finally");
                }

                // Запретить сборщику мусора вызывать деструктор
                GC.SuppressFinalize(this);
            }
        }
    }

    public partial class FormExampleLocalMethods : Form
    {
        public FormExampleLocalMethods()
        {
            InitializeComponent();
        }

        private void buttonGetNewValue_Click(object sender, EventArgs e)
        {
            log.Clear();

            var value = 1;

            log.AppendText(value + Environment.NewLine);

            value = GetNewValue(value);
            log.AppendText(value + Environment.NewLine);

            value = GetNewValue(value);
            log.AppendText(value + Environment.NewLine);

            int GetNewValue(int val) => val + 1;
        }


        private void buttonGetNewValueFromClass_Click(object sender, EventArgs e)
        {
            log.Clear();

            using (var person1 = new ClassPerson(@"Name1"))
            {
                log.AppendText(person1.Name + Environment.NewLine);
            }

            using (var person2 = new ClassPerson(@"Name2"))
            {
                log.AppendText(person2.Name + Environment.NewLine);
            }
        }
    }
}
