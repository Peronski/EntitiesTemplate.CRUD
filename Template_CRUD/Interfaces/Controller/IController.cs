using Test_Cinema.Persisters;
using Test_Cinema.Retrievers;

namespace Test_Cinema.Controllers { 
    public interface IController<T> {
        public IRetriever<T> Retriever { get; }
        public IPersister<T> Persister { get; }

        public T Get(int Id) {
            return Retriever.Get(Id);
        }

        public void Add(T product) {
            Persister.Add(product);
        }

        public void Update(T product, int id) {
            Persister.Update(product, id);
        }

        public void Delete(int id) {
            Persister.Delete(id);
        }

        public IEnumerable<T> GetAll() {
            return Retriever.GetAll();
        }
    }
}
