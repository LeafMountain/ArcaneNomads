using System.Collections; 
using System.Collections.Generic; 

public class Grid {

	public int2[,] positions;
	public List<Element> elements = new List<Element>();

	public Grid(int width, int height){
		CreateGrid(width, height);
	}

	void CreateGrid(int sizeX, int sizeY) {
		positions = new int2[sizeX, sizeY];
	}

	public void AddElement(Element element){
		elements.Add(element);
	}

	public void RemoveElement(Element element){
		elements.Remove(element);
	}

	public void RemoveElement(int index){
		elements.RemoveAt(index);
	}

	public struct Position {
		int x, y;

		public Position(int x, int y) {
			this.x = x;
			this.y = y;
		}
	}

	//An element occuping slots in the grid
	public struct Element {
		public int2 size;

		List < Position > positions;
	}
}
