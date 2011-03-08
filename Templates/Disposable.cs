/*
 * Created by SharpDevelop.
 * User: pry09099729
 * Date: 08/03/2011
 * Time: 09:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace OpticianDB.Templates
{
	/// <summary>
	/// Description of Disposable.
	/// </summary>
	public class Disposable : IDisposable
	{
		/// <summary>
		/// Releases unmanaged and - optionally - managed resources
		/// </summary>
		/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				// free managed resources
			}
			// free native resources if there are any.
		}
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="DBBackEnd"/> is reclaimed by garbage collection.
		/// </summary>
		~DBBackEnd()
		{
			// Finalizer calls Dispose(false)
			this.Dispose(false);
		}
		
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
