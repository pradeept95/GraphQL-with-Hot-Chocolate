# GraphQL-with-Hot-Chocolate

# Client Query with pagine, filtering and sorting

	query{
	 employees
	  ( first :1
	    order_by :{ firstName : ASC}
	    where : 
	    {  
	      lastName_contains : "th" 
		}){
			edges{
	      cursor 
	    }
	    nodes{
	      ...employeeFields
	    }
	    totalCount
	    pageInfo{
	      hasNextPage
	      hasPreviousPage
	      endCursor
	      startCursor
	    }
		}  
	}

	fragment employeeFields on Employee{
	  id
	  firstName
	  lastName
	  emailAddresses{
	    email
	  }
	  addresses{
	    addressLine1
	  }
	}


 # Mutation - Create employee
 
		 mutation CreateEmployee($query: EmployeeInput!){
		  create(employee: $query) {
		    firstName
		    lastName
		  }
		}

			### Quer Object
			{
			  "query" : {
			    "id": 3,
			    "firstName" : "Susan",
			    "lastName" : "Gautam",
			    "addresses": [{
			      "id": 20,
			      "addressLine1": "9877"
			    }],
			    "phones": [{
			      "id": 25,
			      "phNumber": "54645645645"
			    }],
			    "emailAddresses": [
			      {
				"email": "pradeep@gmail.com",
				"id": 55
			      },
			      {
				"email": "pradeeep3@gmail.com",
				"id": 56
						}
			    ]
			  }
			}
