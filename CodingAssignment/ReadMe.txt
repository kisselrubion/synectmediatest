Assignment Overview:

A simple .Net Core API project that provides you with a basic infrastructure of the following:

	1. API Controller with (yet to be implemented) RESTFUL API methods 
	2. A data service to execute CRUD operations on a json file
	3. Data model that represent the json file and a simple structure json file
	4. DataFile.json in the app folder
	5. Hooked up swagger interface to test the API calls 

Assignment Requirements:
	 
	 In brief, the assignment requires you to implement the unimplemented methods and expend (if necessary) the implemented methods. 
	 
	 * FileData.json, DataFileModel.cs and DataModel.cs
		1. Expend file and classes to support an additional data structure under the DataModel.cs. The data structure should be a dictionary of
		   key int and value list of strings. Please prepopulate the structure in the json file with basic data, I.e. 2 keys with each 
		   having a list of 4 strings
		2. Please note the id value in DataModel is a key and should be unique
		3. The program require data presistence. Therefore, any changes 
	 
	 * FileController
		1. Use dependency injection to inject the file manager service class
		2. Implement the Get/Post/Put/Delete methods
		3. Add the ability to get a DataModel by its Id.

	 * FileManagerService
		1. Implement the methods inherited from the IFileManagerService interface (Please look at interface to understand the requirements of each method)
		2. You can expend/refactor if necessary, the GetData method
		3. You can change the method signatures but not their basic functionality requirements 

		Feel free to add any error handling or extra classes/service which you want think is needed! Please refrain from using third party nugut packages  
		other than the ones provided.

	 *** Bonus ***
		 Use the unit test project to preform additional (quality) unit testing

Please either send a zip file of your solution or preferably a link to a GitHub (or equivalent) repo with the solution