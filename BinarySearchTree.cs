public class BinarySearchTree
{
    public Node root { get; set; }
    public BinarySearchTree()
    {
        root = null;
    }

    public void insertElement(int nodeContent)
    {
        Node newNode = new Node();
        newNode.content = nodeContent;
        // if the root is empty, this will be the start of a new BST
        if (root == null)
        {
            root = newNode;
        }
        // if the root is not empty, a tree already exists.
        else
        {
            Node current = root;
            Node parent;
            while (true)
            {
                parent = current; // set the parent to whatever the current root is.
                if (nodeContent < current.content)
                {
                    current = current.Left;
                    if (current == null) // This is for when we reach the bottom of tree
                    {
                        parent.Left = newNode;
                        break;
                    }
                }

                else
                {
                    current = current.Right;
                    if (current == null) // When we reach the bottom of tree
                    {
                        parent.Right = newNode;
                        break;
                    }
                }

            }
        }
    }

    public void Main(String[] args)
    {

        BinarySearchTree nums = new BinarySearchTree();
        nums.Insert(50);
        nums.Insert(17);
        nums.Insert(23);
        nums.Insert(12);
        nums.Insert(19);
        nums.Insert(54);
        nums.Insert(9);
        nums.Insert(14);
        nums.Insert(67);
        nums.Insert(76);
        nums.Insert(72);
    }

}