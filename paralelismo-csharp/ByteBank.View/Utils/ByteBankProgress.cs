using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.View.Utils
{
    public class ByteBankProgress<T> : IProgress<T> //criando generica para ser reutilizavel
    {
        private readonly Action<T> _handler;
        private readonly TaskScheduler _taskScheduler;

        public ByteBankProgress(Action<T> handler) //nao se preocupa com retorno = action | se preocupa = retorno
        {
            _taskScheduler = TaskScheduler.FromCurrentSynchronizationContext();
            _handler = handler;
        }

        public void Report(T value)
        {
            Task.Factory.StartNew(
                    () => _handler(value),
                    System.Threading.CancellationToken.None,
                    TaskCreationOptions.None,
                    _taskScheduler
                );
        }
    }
}
