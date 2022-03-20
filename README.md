# In-Memory-Cache-.Net-Core

The goal of this example will be to use the IMemoryCache to cache some data in 
memory and return it on consecutive API calls. In our case, we will want to cache the 
list of categories (we assume that this data changes infrequently).

For further details on this topic, I recommend you read the official Microsoft Docs:
https://docs.microsoft.com/en-us/aspnet/core/performance/caching/memory?view=aspnetcore-6.0
