


/// <summary>Assets.Project.VisualTreeTest.Runtime</summary>
namespace Assets.Project.VisualTreeTest.Runtime
{
	/// <summary>VisualTree_MonoBehaviour</summary>
	public class VisualTree_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		public bool value_bool;
		public int value_int;
		
		[System.Serializable]
		public class Class
		{
			public int member_a;
			public int member_b;
			public int member_c;
		}

		public Class value_class;

		[System.Serializable]
		public struct Struct
		{
			public int member_a;
			public int member_b;
			public int member_c;
		}

		public Struct value_struct;

		public Class[] value_class_list;

		public Struct[] value_struct_list;
	}
}

