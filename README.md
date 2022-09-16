
![alt text](https://i.stack.imgur.com/BrnFy.png)

# TourBooking

********************************
I Am Glad You Are Here :)
********************************

Please Follow the Steps to run the program:
- Set connection string in project "TourBooking.WebApi > appsettings.Development.json"
- In the Package Manager Console set the Default Project on "TourBooking.Infrastructure" and write "add-migration anyName"
- In the Package Manager Console write "update-database"
- Set project "TourBooking.WebApi" as a startup project
- Start Debugging


GraphQl Address:
https://YOURLocalhost/graphql/

Voyager Address:
https://YOURLocalhost/graphql-voyager

********
Sample GraphQL Queries:
(Filtering and Sorting are Enabled)

Get Bookings:

query{
  booking{
    bookingId
    name
    status
    price
    currency
    partyLeaderId
    partyLeader {
      partyLeaderId
      name
    }
  }
}

*****************
Add Booking:

mutation {
  addBooking(
    input: {
      booking: {
        status:1,
        currency: 8
        name: "darush"
        createDate: "1990-02-02"
        bookingId: "D2FC8DEA-E40C-4B05-805C-B19C97891F24",
        partyLeaderId:"d2fc8dea-e40c-4b09-805c-b19c99991f24",
        price: 1200,
      }
    }
  ) {
    booking {
      name
      price
      currency
    }
  }
}


*******************************************
  Your support means a lot to me! Thanks!
*******************************************

