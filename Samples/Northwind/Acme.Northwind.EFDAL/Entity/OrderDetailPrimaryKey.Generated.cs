using System;
using nHydrate.EFCore.DataAccess;

namespace Acme.Northwind.EFDAL.Entity
{
	#region OrderDetailPrimaryKey

	/// <summary>
	/// A strongly-typed primary key object for the 'OrderDetail' table.
	/// </summary>
	[Serializable()]
	[System.CodeDom.Compiler.GeneratedCode("nHydrateModelGenerator", "5.0.1.100")]
	public partial class OrderDetailPrimaryKey : nHydrate.EFCore.DataAccess.IPrimaryKey
	{
		/// <summary>
		/// A primary key field of the OrderDetail entity
		/// </summary>
		protected int _orderID;
		/// <summary>
		/// A primary key field of the OrderDetail entity
		/// </summary>
		protected int _productID;

		/// <summary>
		/// The constructor for this object which takes the fields that comprise the primary key for the 'OrderDetail' table.
		/// </summary>
		public OrderDetailPrimaryKey(int orderID, int productID)
		{
			_orderID = orderID;
			_productID = productID;
		}

		/// <summary>
		/// A primary key for the 'OrderDetail' table.
		/// </summary>
		public int OrderID
		{
			get { return _orderID; }
		}

		/// <summary>
		/// A primary key for the 'OrderDetail' table.
		/// </summary>
		public int ProductID
		{
			get { return _productID; }
		}

		/// <summary>
		/// Returns a value indicating whether the current object is equal to a specified object.
		/// </summary>
		public override bool Equals(object obj)
		{
			if (obj == null) return false;
			if (obj.GetType() == this.GetType())
			{
				var retval = true;
				retval &= (this.OrderID == ((Acme.Northwind.EFDAL.Entity.OrderDetailPrimaryKey)obj).OrderID);
				retval &= (this.ProductID == ((Acme.Northwind.EFDAL.Entity.OrderDetailPrimaryKey)obj).ProductID);
				return retval;
			}
			return false;
		}

		/// <summary>
		/// Serves as a hash function for this particular type.
		/// </summary>
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

	}

	#endregion

}
