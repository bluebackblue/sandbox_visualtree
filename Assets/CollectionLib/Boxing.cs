


/// <summary>CollectionLib</summary>
namespace CollectionLib
{
	/// <summary>Boxing</summary>
	[System.Serializable]
	public class Boxing<T>
		where T : struct
	{
		/// <summary>value</summary>
		[UnityEngine.SerializeField]
		public T value;

		/// <summary>constructor</summary>
		public Boxing(T a_value)
		{
			this.value = a_value;
		}

		/// <summary>constructor</summary>
		public Boxing()
		{
			this.value = default;
		}
	}
}

