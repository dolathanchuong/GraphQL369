# GraphQL369
In this first session, you have learned how you can create a simple GraphQL project on top of ASP.NET Core. You have leveraged Entity Framework to create your models and save those to the database. Together, ASP.NET Core, Entity Framework, and Hot Chocolate let you build a simple GraphQL server quickly.

# URL POST 
http://localhost:5211/graphql/
# $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$__QUERY__$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
# Get Speaker With List Id
    query
    {
        speakersById(ids: [1,2])
            {
            id
            name
            bio
            webSite
        }
    }
# Node has not been fixed yet
    query {
    node(id: "U3BlYWtlcgppMQ==") {
        ... on Speaker {
        id
        name
        }
    }
    }
# Get Session
    query GetSessionById {
    sessionsById(ids: [1]) {
      id
      speakers {
        id
        name
      }
      startTime
      title
    }
  }
# Get Tracks
    query{
        tracks{
            id
            name
        }	
    }
# Track By Name
    query
    {
        trackByNames(names:"Track 1")
        {
            id
        }
    }
# Get Speaker Multiable Id
    query {
    speaker1: speaker(id: 1) {
        name
    }
    speaker2: speaker(id: 2) {
        name
    }
        speaker3: speaker(id: 3) {
        name
    }
    }
# Get Speaker With Sessions
    query GetSpeakerWithSessions {
        speakers {
            name
            sessions 
            {
                id
                title
            }
        }
    }
# Get Speakers
    query {
        speakers {
            id
            name
            bio
            webSite
        }
    }
# Get Speaker with Id
    query{
        speakerById(id:3){
            id
            name
        }
    }
# Get Speaker Names
    query GetSpeakerNames {
        speakers
        {
            name
        }
    }
# Get Specific Speaker By Id 
    query GetSpecificSpeakerById {
        a: speaker(id: 1) {
                id
            name
        }
        b: speaker(id: 2) {
                id
            name
        }
        c: speaker(id: 3) {
                id
            name
        }
    }
# Get Speaker Names In Parallel
    query GetSpeakerNamesInParallel {
        a: speakers {
            name
            bio
        }
        b: speakers {
            name
            bio
        }
        c: speakers {
            name
            bio
        }
    }
# $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$__MUTATION__$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
# Add Session
    mutation AddSession{
        addSession(
            input:
            {
                title: "The tour of c#",
                speakerIds:[1],
            })
            {
                session 
                {
                    id
                }
            }
        }
# Add Track 
    mutation AddTrack{
        addTrack(
            input:{
            name:"Track 369",
        })
        {
            errors 
            {
                code,
                message
            },
            track
            {
                id
            }
        }
    }
# Add Speaker
    mutation AddSpeaker {
		  addSpeaker(
                input: {
                    name: "Speaker Name36899"
                    bio: "Speaker Bio36899"
                    webSite: "http://speaker.website36999" 
                    }
                ) 
                {
                    speaker { id }
                }
		}



