using System.Collections.Generic;

namespace ConsolePractice
{
    public class DocumentManager<T>
    {
        private readonly Queue<T> documentQueue = new Queue<T>();
        public void AddDocument(T doc)
        {
            lock (this)
            {
                documentQueue.Enqueue(doc);
            }
        }
        public bool IsDocumentAvailable
        {
            get { return documentQueue.Count > 0; }
        }
        public T GetDocument()
        {
            T doc = default(T);
            lock (this)
            {
                doc = documentQueue.Dequeue();
            }
            return doc;
        }
    }
}
