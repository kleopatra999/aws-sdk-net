# Amazon DynamoDB
 

This is the Amazon DynamoDB API Reference. This guide provides descriptions of the low-level DynamoDB API.

 

This guide is intended for use with the following DynamoDB documentation:

 
- [Amazon DynamoDB Getting Started Guide](http://docs.aws.amazon.com/amazondynamodb/latest/gettingstartedguide/) - provides hands-on exercises that help you learn the basics of working with DynamoDB. *If you are new to DynamoDB, we recommend that you begin with the Getting Started Guide.*
- [Amazon DynamoDB Developer Guide](http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/) - contains detailed information about DynamoDB concepts, usage, and best practices.
- [Amazon DynamoDB Streams API Reference](http://docs.aws.amazon.com/dynamodbstreams/latest/APIReference/) - provides descriptions and samples of the DynamoDB Streams API. (For more information, see [Capturing Table Activity with DynamoDB Streams](http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Streams.html) in the Amazon DynamoDB Developer Guide.)
 

Instead of making the requests to the low-level DynamoDB API directly from your application, we recommend that you use the AWS Software Development Kits (SDKs). The easy-to-use libraries in the AWS SDKs make it unnecessary to call the low-level DynamoDB API directly from your application. The libraries take care of request authentication, serialization, and connection management. For more information, see [Using the AWS SDKs with DynamoDB](http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/UsingAWSSDK.html) in the Amazon DynamoDB Developer Guide.

 

If you decide to code against the low-level DynamoDB API directly, you will need to write the necessary code to authenticate your requests. For more information on signing your requests, see [Using the DynamoDB API](http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/API.html) in the *Amazon DynamoDB Developer Guide*.

 

The following are short descriptions of each low-level API action, organized by function.

 

**Managing Tables**

 
- *CreateTable* - Creates a table with user-specified provisioned throughput settings. You must define a primary key for the table - either a simple primary key (partition key), or a composite primary key (partition key and sort key). Optionally, you can create one or more secondary indexes, which provide fast data access using non-key attributes.
- *DescribeTable* - Returns metadata for a table, such as table size, status, and index information.
- *UpdateTable* - Modifies the provisioned throughput settings for a table. Optionally, you can modify the provisioned throughput settings for global secondary indexes on the table.
- *ListTables* - Returns a list of all tables associated with the current AWS account and endpoint.
- *DeleteTable* - Deletes a table and all of its indexes.
 

For conceptual information about managing tables, see [Working with Tables](http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithTables.html) in the *Amazon DynamoDB Developer Guide*.

 

**Reading Data**

 
- *GetItem* - Returns a set of attributes for the item that has a given primary key. By default, *GetItem* performs an eventually consistent read; however, applications can request a strongly consistent read instead.
- *BatchGetItem* - Performs multiple *GetItem* requests for data items using their primary keys, from one table or multiple tables. The response from *BatchGetItem* has a size limit of 16 MB and returns a maximum of 100 items. Both eventually consistent and strongly consistent reads can be used.
- *Query* - Returns one or more items from a table or a secondary index. You must provide a specific value for the partition key. You can narrow the scope of the query using comparison operators against a sort key value, or on the index key. *Query* supports either eventual or strong consistency. A single response has a size limit of 1 MB.
- *Scan* - Reads every item in a table; the result set is eventually consistent. You can limit the number of items returned by filtering the data attributes, using conditional expressions. *Scan* can be used to enable ad-hoc querying of a table against non-key attributes; however, since this is a full table scan without using an index, *Scan* should not be used for any application query use case that requires predictable performance.
 

For conceptual information about reading data, see [Working with Items](http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithItems.html) and [Query and Scan Operations](http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/QueryAndScan.html) in the *Amazon DynamoDB Developer Guide*.

 

**Modifying Data**

 
- *PutItem* - Creates a new item, or replaces an existing item with a new item (including all the attributes). By default, if an item in the table already exists with the same primary key, the new item completely replaces the existing item. You can use conditional operators to replace an item only if its attribute values match certain conditions, or to insert a new item only if that item doesn't already exist.
- *UpdateItem* - Modifies the attributes of an existing item. You can also use conditional operators to perform an update only if the item's attribute values match certain conditions.
- *DeleteItem* - Deletes an item in a table by primary key. You can use conditional operators to perform a delete an item only if the item's attribute values match certain conditions.
- *BatchWriteItem* - Performs multiple *PutItem* and *DeleteItem* requests across multiple tables in a single request. A failure of any request(s) in the batch will not cause the entire *BatchWriteItem* operation to fail. Supports batches of up to 25 items to put or delete, with a maximum total request size of 16 MB.
 

For conceptual information about modifying data, see [Working with Items](http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithItems.html) and [Query and Scan Operations](http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/QueryAndScan.html) in the *Amazon DynamoDB Developer Guide*.






### AWS Mobile SDK for Xamarin






The AWS Mobile SDK for Xamarin provides a set of .NET libraries, code samples, and documentation to help developers build connected mobile applications for iOS, Android, Windows 8, and Windows Phone devices. Mobile apps written using Xamarin call native platform APIs so they have the look and feel of native applications. The .NET libraries in the SDK provide C# wrappers around the AWS REST API implemented by AWS services.