using Unity.Engine;
using Unity.Editor;
using System.Collections;


public class MeshClassForRiverMesh { 
    public MeshXVector Vector3;
    public MeshYVector Vector3;
    public MeshZVector Vector3;
    public float MeshSizeControl = 1000f;
    public int MaximumMeshSizeHeight = 1000;
    public int MaximumMeshSizeWidth = 1000;

	void MeshFunction()
    {
        MeshXVector = new Vector3(100f, 0.0f, 0.0f);
        MeshYVector = new Vector3(0.0f, 100f, 0.0f);
        MeshZVector = new Vector3(0.0f, 0.0f, 100f);
        MeshFindingFunction = GetComponent<RiverMesh>;

        Vector3 MeshXSize;
        Vector3 MeshYSize;
        Vector3 MeshZSize;


       
    }
	
}
