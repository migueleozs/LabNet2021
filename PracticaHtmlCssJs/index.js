$(function(){
    var name, lastname;
    $(".btnAction").on('click', function(){
        name = $(".name").val();
        lastname = $(".lastname").val();
        console.log(name + ' ' + lastname);
        if (name.length==0||lastname.length==0){
            alert("Nombre o Apellido vacio");
        }
        
    });
});

$(function(){
        let btnClear = document.querySelector('button');
        let inputs = document.querySelectorAll('input');
    $(".btnClear").on('click', function(){
        inputs.forEach(input => input.value = '');
        
    });
});
