define(function(){
	return function WordChain(dictionary) {

		if(!(this instanceof WordChain)){
			return new WordChain(dictionary);
		}
  			var self = this, _dictionary = dictionary;

  			self.getChain = function(startWord, targetWord){
  				if(startWord == null) return;
  				if(targetWord == null) return;
  			}


  			return self;
	}
})


