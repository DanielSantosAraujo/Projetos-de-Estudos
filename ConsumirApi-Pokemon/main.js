// const name = document.querySelector("#name")

// const showData = (result) => {
//     for(const campo in result){
//         if(document.querySelector("#"+campo)){
//             document.querySelector("#"+campo).value = result[campo]
//         }
        
//     }
// }

// const url =

//     fetch(`https://pokeapi.co/api/v2/`)
//     .then(response=>{response.json()
//         .then( data => console.log(data))
//     })
//     .catch(e => console.log('Deu erro:' + e,message))

function fetchApiData() {
    fetch('https://pokeapi.co/api/v2/pokemon').then((response) => {
        console.log(response);
    })
}