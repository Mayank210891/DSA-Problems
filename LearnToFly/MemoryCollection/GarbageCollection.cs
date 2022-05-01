using System;
using System.Net.Http;

namespace LearnToFly.MemoryCollection
{
    // garbage collection: it is a process of cleaning the unused memory locations.
    // CLR allocates memory into the managed heap when object is created
    // there are 2 types of resources.
    // 1. Managed Resources - which lies inside CLR boundries
    // 2. Unmanaged Resources - which lies outside CLR boundries
    // MANAGED HEAP: CLR does all the memory allocation in contigous memory space, which is known as managed heap.
    // a Managed Heap always contains the address of next available space or contains null.
    // ** All the threads created inside the process allocates memeory in the same managed heap.**


    // a memory(managed heap) has 3 logical segments known as generations
    // i).   0 generation - short lived objects. GC generally runs here
    // ii).  1st generation - objects last longer than ) generation
    // iii). 2nd generation - objects that live longest in the memory(Ex. Singleton)

    // How does collection happens?
    // Garbage Collector is a component inside CLR that in non-deterministic way automatically clears up the free or unused
    // memory allocation
    // it determines if an object is no longer in use by determining the roots of the application.
    // From the roots GC creates a graph of the objects which are linked to each of the roots.
    // the objects which are not in graph, but are in the managed heap are essentially ready to be collected.
    // GC then calls memory copying function to compact the objects which are still in the graph and move them close
    // to each other and freeing up memory. This operation will occur only if the significant number of objects needs to be
    // released.
    // GC then adjust the pointer to the next available memory location
    // Steps taken by GC during collection method:
    // a. Marking
    // b. Relocating
    // c. Compacting
    // Finalize or Dispose
    // Finalize: used by CLR when a class implements Finalize method also known as destructor.
    public class GarbageCollection : IDisposable
    {
        private readonly HttpClient httpClient;
        private bool disposed = false;
        public GarbageCollection(IHttpClientFactory httpClientFactory)
        {
            this.httpClient = httpClientFactory.CreateClient();
        }

        ~GarbageCollection()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        // derived class can also override this method
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                // Dispose managed object
                httpClient.Dispose();
            }

            // dispose unmanaged object

            disposed = true;
        }
        public void Get()
        {
            var response = this.httpClient.GetAsync("");
        }

        public void Post(string request)
        {
            var response = this.httpClient.PostAsync("", new StringContent(request));
        }
    }
}
