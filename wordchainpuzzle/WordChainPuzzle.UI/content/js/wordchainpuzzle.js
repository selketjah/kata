define(function(){
	return function WordChain(dictionary) {

		if(!(this instanceof WordChain)){
			return new WordChain(dictionary);
		}
  			var self = this, _dictionary = dictionary;

  			self.getChain = function(startWord, targetWord){
  				if(startWord == null) throw "start word needs to be filled in.";
  				if(targetWord == null) throw "target word needs to be filled in.";

  				

  			}


  			return self;
	}
})


