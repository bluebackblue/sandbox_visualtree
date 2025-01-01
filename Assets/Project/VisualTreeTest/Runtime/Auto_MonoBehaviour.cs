


/// <summary>Assets.Project.VisualTreeTest.Runtime</summary>
namespace Assets.Project.VisualTreeTest.Runtime
{
	/// <summary>Auto_MonoBehaviour</summary>
	public class Auto_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		[UnityEngine.SerializeField]
		public bool value_bool;

		[UnityEngine.SerializeField]
		public int value_int;
		
		[System.Serializable]
		public class Class
		{
			[UnityEngine.SerializeField]
			public int member_a;

			[UnityEngine.SerializeField]
			public int member_b;

			[UnityEngine.SerializeField]
			public int member_c;
		}

		[UnityEngine.SerializeField]
		public Class value_class;

		[System.Serializable]
		public struct Struct
		{
			[UnityEngine.SerializeField]
			public int member_a;

			[UnityEngine.SerializeField]
			public int member_b;

			[UnityEngine.SerializeField]
			public int member_c;
		}

		[UnityEngine.SerializeField]
		public Struct value_struct;

		[UnityEngine.SerializeField]
		public Class[] value_class_list;

		[UnityEngine.SerializeField]
		public Struct[] value_struct_list;
	}
}

