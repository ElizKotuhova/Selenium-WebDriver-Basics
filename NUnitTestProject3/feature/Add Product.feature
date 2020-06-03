Feature: AllProduct

		As a user
		I want to create a product 
		So I can create a new product


		Scenario: Login

		Given I open "http://localhost:5000/" url
		When I type my value Name and Pussword
		And I click button "Enter" Login

		When I click on the link All Products
		And I click the Create new button
		And I type "Anything" ProductName
		And I pick Category
		And I pick Supplier
		And I fill fields "12" UnitPrice, "1" QuantityPerUnit, "1" UnitsInStock, "1" UnitsOnOrder, "1" ReorderLevel

		And I click button Enter Product
		Then I check that Anything product has been created