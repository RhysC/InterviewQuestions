using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CandidateExercises.Multithreading
{
	class ThreadSafety
	{
		private int _counter;

		public void Increment()
		{
			_counter++;
		}

		private volatile int _volatileCounter;
		public void VolatileIncrement()
		{
			_volatileCounter++;
		}

		public void IncrementLock1()
		{
			lock (this)
			{
				_counter++;
			}
		}

		public void IncrementLock2()
		{
			lock (GetType())
			{
				_counter++;
			}
		}

		private string _lockString = "Lock";
		public void IncrementLock3()
		{
			lock (_lockString)
			{
				_counter++;
			}
		}
	}
}
