function getMoviePrice([movie, dayOfWeek]) {
    movie = movie.toLocaleLowerCase();
    dayOfWeek = dayOfWeek.toLocaleLowerCase();

    const error = 'error';

    if(movie == 'the godfather'){
        switch(dayOfWeek){
            case 'monday': return 12;
            case 'tuesday': return 10;
            case 'wednesday': return 15;
            case 'thursday': return 12.50;
            case 'friday': return 15;
            case 'saturday': return 25;
            case 'sunday': return 30;
            default: return error;
        }
    }
    else if(movie == 'schindler\'s list'){
        switch(dayOfWeek){
            case 'monday': return 8.5;
            case 'tuesday': return 8.5;
            case 'wednesday': return 8.5;
            case 'thursday': return 8.5;
            case 'friday': return 8.5;
            case 'saturday': return 15;
            case 'sunday': return 15;
            default: return error;
        }
    }
    else if(movie == 'casablanca'){
        switch(dayOfWeek){
            case 'monday': return 8;
            case 'tuesday': return 8;
            case 'wednesday': return 8;
            case 'thursday': return 8;
            case 'friday': return 8;
            case 'saturday': return 10;
            case 'sunday': return 10;
            default: return error;
        }
    }
    else if(movie == 'the wizard of oz'){
        switch(dayOfWeek){
            case 'monday': return 10;
            case 'tuesday': return 10;
            case 'wednesday': return 10;
            case 'thursday': return 10;
            case 'friday': return 10;
            case 'saturday': return 15;
            case 'sunday': return 15;
            default: return error;
        }
    }
    else{
        return error;
    }
}

//console.log(getMoviePrice(['The Godfather', 'Friday']));