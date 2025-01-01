


/// <summary>define</summary>
#define DEF_DEBUGVIEW



/// <summary>Assets.Project.VisualTreeTest.Editor</summary>
namespace Assets.Project.VisualTreeTest.Editor
{
	/// <summary>Test_CustomEditor</summary>
	[UnityEditor.CustomEditor(typeof(Runtime.VisualTree_MonoBehaviour))]
	public class Test_CustomEditor : UnityEditor.Editor 
	{
		/// <summary>ItemController</summary>
		#if(DEF_DEBUGVIEW)
		UnityEngine.UIElements.Label debugview;
		#endif

		/// <summary>DebugViewUpdate</summary>
		#if(DEF_DEBUGVIEW)
		public void DebugViewUpdate()
		{
			if(target is Runtime.VisualTree_MonoBehaviour monobehaviour){
				System.Text.StringBuilder stringbuilder = new System.Text.StringBuilder();

				stringbuilder.Append("value_bool = ");
				stringbuilder.Append(monobehaviour.value_bool);
				stringbuilder.Append("\n");

				stringbuilder.Append("value_int = ");
				stringbuilder.Append(monobehaviour.value_int);
				stringbuilder.Append("\n");

				for(int ii=0;ii<monobehaviour.value_class_list.Length;ii++){

					stringbuilder.Append("value_class_list[");
					stringbuilder.Append(ii);
					stringbuilder.Append("]member_a = ");
					stringbuilder.Append(monobehaviour.value_class_list[ii].member_a);
					stringbuilder.Append("\n");

					stringbuilder.Append("value_class_list[");
					stringbuilder.Append(ii);
					stringbuilder.Append("]member_b = ");
					stringbuilder.Append(monobehaviour.value_class_list[ii].member_b);
					stringbuilder.Append("\n");

					stringbuilder.Append("value_class_list[");
					stringbuilder.Append(ii);
					stringbuilder.Append("]member_c = ");
					stringbuilder.Append(monobehaviour.value_class_list[ii].member_c);
					stringbuilder.Append("\n");
				}

				for(int ii=0;ii<monobehaviour.value_struct_list.Length;ii++){

					stringbuilder.Append("value_struct_list[");
					stringbuilder.Append(ii);
					stringbuilder.Append("]member_a = ");
					stringbuilder.Append(monobehaviour.value_struct_list[ii].member_a);
					stringbuilder.Append("\n");

					stringbuilder.Append("value_struct_list[");
					stringbuilder.Append(ii);
					stringbuilder.Append("]member_b = ");
					stringbuilder.Append(monobehaviour.value_struct_list[ii].member_b);
					stringbuilder.Append("\n");

					stringbuilder.Append("value_struct_list[");
					stringbuilder.Append(ii);
					stringbuilder.Append("]member_c = ");
					stringbuilder.Append(monobehaviour.value_struct_list[ii].member_c);
					stringbuilder.Append("\n");
				}

				this.debugview.text = stringbuilder.ToString();
			}
		}
		#endif

		/// <summary>CreateInspectorGUI</summary>
		public override UnityEngine.UIElements.VisualElement CreateInspectorGUI()
		{
			//update
			#if(DEF_DEBUGVIEW)
			{
				UnityEditor.EditorApplication.update -= DebugViewUpdate;
				UnityEditor.EditorApplication.update += DebugViewUpdate;
			}
			#endif

			UnityEngine.UIElements.VisualElement t_root = new UnityEngine.UIElements.VisualElement();
			UnityEditor.UIElements.BindingExtensions.Bind(t_root,serializedObject);

			{
				//Toggle
				{
					UnityEngine.UIElements.Toggle t_toggle = new UnityEngine.UIElements.Toggle("value_bool");
					t_toggle.bindingPath = "value_bool";
					t_root.Add(t_toggle);
				}

				//IntegerField
				{
					UnityEngine.UIElements.IntegerField t_integerfield = new UnityEngine.UIElements.IntegerField("value_int");
					t_integerfield.bindingPath = "value_int";
					t_root.Add(t_integerfield);
				}

				//ListView
				{
					UnityEngine.UIElements.ListView t_listview = new UnityEngine.UIElements.ListView();
					t_listview.bindingPath = "value_class_list";
					t_listview.virtualizationMethod = UnityEngine.UIElements.CollectionVirtualizationMethod.DynamicHeight;

					t_listview.reorderMode = UnityEngine.UIElements.ListViewReorderMode.Animated;
					t_listview.showAddRemoveFooter = true;
					t_listview.showBorder = true;
					t_listview.showFoldoutHeader = true;
					t_listview.headerTitle = "value_class_list";
					t_listview.allowRemove = true;
					t_listview.allowAdd = true;
					t_listview.bindingSourceSelectionMode = UnityEngine.UIElements.BindingSourceSelectionMode.AutoAssign;
					t_listview.showBoundCollectionSize = true;

					t_listview.makeItem += ()=>{
						UnityEngine.UIElements.VisualElement t_itemroot = new UnityEngine.UIElements.VisualElement();

						if(target is Runtime.VisualTree_MonoBehaviour monobehaviour){

							UnityEngine.UIElements.Foldout t_foldout = new UnityEngine.UIElements.Foldout();
							t_foldout.text = "element";
							t_foldout.name = "root";

							t_itemroot.Add(t_foldout);
							{
								{
									UnityEngine.UIElements.IntegerField t_integerfield = new UnityEngine.UIElements.IntegerField("member_a");
									t_foldout.Add(t_integerfield);
									{
										t_integerfield.name = "member_a";
										t_integerfield.userData = new CollectionLib.Boxing<int>();
										t_integerfield.RegisterCallback<UnityEngine.UIElements.ChangeEvent<int>>((UnityEngine.UIElements.ChangeEvent<int> changeevent) =>{
											if(t_integerfield.userData is CollectionLib.Boxing<int> value){
												int t_index = value.value;
												monobehaviour.value_class_list[t_index].member_a = changeevent.newValue;
											}
										});
									}
								}

								{
									UnityEngine.UIElements.IntegerField t_integerfield = new UnityEngine.UIElements.IntegerField("member_b");
									t_foldout.Add(t_integerfield);
									{
										t_integerfield.name = "member_b";
										t_integerfield.userData = new CollectionLib.Boxing<int>();
										t_integerfield.RegisterCallback<UnityEngine.UIElements.ChangeEvent<int>>((UnityEngine.UIElements.ChangeEvent<int> changeevent) =>{
											if(t_integerfield.userData is CollectionLib.Boxing<int> value){
												int t_index = value.value;
												monobehaviour.value_class_list[t_index].member_b = changeevent.newValue;
											}
										});
									}
								}

								{
									UnityEngine.UIElements.IntegerField t_integerfield = new UnityEngine.UIElements.IntegerField("member_c");
									t_foldout.Add(t_integerfield);
									{
										t_integerfield.name = "member_c";
										t_integerfield.userData = new CollectionLib.Boxing<int>();
										t_integerfield.RegisterCallback<UnityEngine.UIElements.ChangeEvent<int>>((UnityEngine.UIElements.ChangeEvent<int> changeevent) =>{
											if(t_integerfield.userData is CollectionLib.Boxing<int> value){
												int t_index = value.value;
												monobehaviour.value_class_list[t_index].member_c = changeevent.newValue;
											}
										});
									}
								}
							}
						}

						return t_itemroot;
					};

					t_listview.bindItem += (UnityEngine.UIElements.VisualElement a_item,int a_index) => {

						if(target is Runtime.VisualTree_MonoBehaviour monobehaviour){

							{
								 UnityEngine.UIElements.Foldout t_foldout = UnityEngine.UIElements.UQueryExtensions.Q<UnityEngine.UIElements.Foldout>(a_item,"root");
								 t_foldout.text = string.Format("Element {0}",a_index);
								 t_foldout.style.marginLeft = new UnityEngine.UIElements.Length(15.0f, UnityEngine.UIElements.LengthUnit.Pixel);
							}

							{
								UnityEngine.UIElements.IntegerField t_integerfield = UnityEngine.UIElements.UQueryExtensions.Q<UnityEngine.UIElements.IntegerField>(a_item,"member_a");
								if(t_integerfield.userData is CollectionLib.Boxing<int> boxing){
									boxing.value = a_index;
									t_integerfield.value = monobehaviour.value_class_list[boxing.value].member_a;
								}
							}

							{
								UnityEngine.UIElements.IntegerField t_integerfield = UnityEngine.UIElements.UQueryExtensions.Q<UnityEngine.UIElements.IntegerField>(a_item,"member_b");
								if(t_integerfield.userData is CollectionLib.Boxing<int> boxing){
									boxing.value = a_index;
									t_integerfield.value = monobehaviour.value_class_list[boxing.value].member_b;
								}
							}

							{
								UnityEngine.UIElements.IntegerField t_integerfield = UnityEngine.UIElements.UQueryExtensions.Q<UnityEngine.UIElements.IntegerField>(a_item,"member_c");
								if(t_integerfield.userData is CollectionLib.Boxing<int> boxing){
									boxing.value = a_index;
									t_integerfield.value = monobehaviour.value_class_list[boxing.value].member_c;
								}
							}
						}
					};

					t_root.Add(t_listview);
				}

				//ListView
				{
					UnityEngine.UIElements.ListView t_listview = new UnityEngine.UIElements.ListView();
					t_listview.bindingPath = "value_struct_list";
					t_listview.virtualizationMethod = UnityEngine.UIElements.CollectionVirtualizationMethod.DynamicHeight;

					t_listview.reorderMode = UnityEngine.UIElements.ListViewReorderMode.Animated;
					t_listview.showAddRemoveFooter = true;
					t_listview.showBorder = true;
					t_listview.showFoldoutHeader = true;
					t_listview.headerTitle = "value_struct_list";
					t_listview.allowRemove = true;
					t_listview.allowAdd = true;
					t_listview.bindingSourceSelectionMode = UnityEngine.UIElements.BindingSourceSelectionMode.AutoAssign;
					t_listview.showBoundCollectionSize = true;

					t_listview.makeItem += ()=>{
						UnityEngine.UIElements.VisualElement t_itemroot = new UnityEngine.UIElements.VisualElement();

						if(target is Runtime.VisualTree_MonoBehaviour monobehaviour){

							UnityEngine.UIElements.Foldout t_foldout = new UnityEngine.UIElements.Foldout();
							t_foldout.text = "element";
							t_foldout.name = "root";

							t_itemroot.Add(t_foldout);
							{
								{
									UnityEngine.UIElements.IntegerField t_integerfield = new UnityEngine.UIElements.IntegerField("member_a");
									t_foldout.Add(t_integerfield);
									{
										t_integerfield.name = "member_a";
										t_integerfield.userData = new CollectionLib.Boxing<int>();
										t_integerfield.RegisterCallback<UnityEngine.UIElements.ChangeEvent<int>>((UnityEngine.UIElements.ChangeEvent<int> changeevent) =>{
											if(t_integerfield.userData is CollectionLib.Boxing<int> value){
												int t_index = value.value;
												monobehaviour.value_struct_list[t_index].member_a = changeevent.newValue;
											}
										});
									}
								}

								{
									UnityEngine.UIElements.IntegerField t_integerfield = new UnityEngine.UIElements.IntegerField("member_b");
									t_foldout.Add(t_integerfield);
									{
										t_integerfield.name = "member_b";
										t_integerfield.userData = new CollectionLib.Boxing<int>();
										t_integerfield.RegisterCallback<UnityEngine.UIElements.ChangeEvent<int>>((UnityEngine.UIElements.ChangeEvent<int> changeevent) =>{
											if(t_integerfield.userData is CollectionLib.Boxing<int> value){
												int t_index = value.value;
												monobehaviour.value_struct_list[t_index].member_b = changeevent.newValue;
											}
										});
									}
								}

								{
									UnityEngine.UIElements.IntegerField t_integerfield = new UnityEngine.UIElements.IntegerField("member_c");
									t_foldout.Add(t_integerfield);
									{
										t_integerfield.name = "member_c";
										t_integerfield.userData = new CollectionLib.Boxing<int>();
										t_integerfield.RegisterCallback<UnityEngine.UIElements.ChangeEvent<int>>((UnityEngine.UIElements.ChangeEvent<int> changeevent) =>{
											if(t_integerfield.userData is CollectionLib.Boxing<int> value){
												int t_index = value.value;
												monobehaviour.value_struct_list[t_index].member_c = changeevent.newValue;
											}
										});
									}
								}
							}
						}

						return t_itemroot;
					};

					t_listview.bindItem += (UnityEngine.UIElements.VisualElement a_item,int a_index) => {

						if(target is Runtime.VisualTree_MonoBehaviour monobehaviour){

							{
								 UnityEngine.UIElements.Foldout t_foldout = UnityEngine.UIElements.UQueryExtensions.Q<UnityEngine.UIElements.Foldout>(a_item,"root");
								 t_foldout.text = string.Format("Element {0}",a_index);
								 t_foldout.style.marginLeft = new UnityEngine.UIElements.Length(15.0f, UnityEngine.UIElements.LengthUnit.Pixel);
							}

							{
								UnityEngine.UIElements.IntegerField t_integerfield = UnityEngine.UIElements.UQueryExtensions.Q<UnityEngine.UIElements.IntegerField>(a_item,"member_a");
								if(t_integerfield.userData is CollectionLib.Boxing<int> boxing){
									boxing.value = a_index;
									t_integerfield.value = monobehaviour.value_struct_list[boxing.value].member_a;
								}
							}

							{
								UnityEngine.UIElements.IntegerField t_integerfield = UnityEngine.UIElements.UQueryExtensions.Q<UnityEngine.UIElements.IntegerField>(a_item,"member_b");
								if(t_integerfield.userData is CollectionLib.Boxing<int> boxing){
									boxing.value = a_index;
									t_integerfield.value = monobehaviour.value_struct_list[boxing.value].member_b;
								}
							}

							{
								UnityEngine.UIElements.IntegerField t_integerfield = UnityEngine.UIElements.UQueryExtensions.Q<UnityEngine.UIElements.IntegerField>(a_item,"member_c");
								if(t_integerfield.userData is CollectionLib.Boxing<int> boxing){
									boxing.value = a_index;
									t_integerfield.value = monobehaviour.value_struct_list[boxing.value].member_c;
								}
							}
						}
					};

					t_root.Add(t_listview);
				}

				#if(DEF_DEBUGVIEW)
				{
					this.debugview = new UnityEngine.UIElements.Label();
					t_root.Add(debugview);
				}
				#endif
			}
			return t_root;
		}
	}
}

