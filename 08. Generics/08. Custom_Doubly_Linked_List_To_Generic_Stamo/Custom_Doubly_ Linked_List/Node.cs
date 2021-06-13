namespace Custom_Doubly_Linked_List_To_Generic
{
    /// <summary>
    /// Елемент от двойно свързан списък
    /// </summary>
    public class Node<T>
    {
        /// <summary>
        /// Стойност на елемента
        /// </summary>
        public T Value { get; set; }
        /// <summary>
        /// Предишен елемент
        /// </summary>
        public Node<T> Previous { get; set; }
        /// <summary>
        /// Следващ елемент
        /// </summary>
        public Node<T> Next { get; set; }
    }
}
