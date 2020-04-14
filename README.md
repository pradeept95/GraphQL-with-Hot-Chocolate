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


 
