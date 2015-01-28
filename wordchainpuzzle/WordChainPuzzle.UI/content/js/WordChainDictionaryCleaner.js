define(function{
	return function WordChainDictionaryCleaner(dictionary){
		if(!(this instanceof WordChainDictionaryCleaner)){
			return new WordChainDictionaryCleaner(dictionary);
		}

		var self = this, _dictionary = dictionary;

		self.Clean = function(wordLength){
			_dictionary = self.RemoveWordsWithDifferentLength(wordLength);
			_dictionary = self.RemoveDuplicates();
			return _dictionary;
		}

		function RemoveWordsWithDifferentLength(wordLength){
			return _dictionary.filter(function(word){
				return word.length === wordLength;
			});
		}

		function RemoveDuplicates(){
			return _dictionary.filter(function(word, index){
				return _dictionary.indexOf(word) === index;
			});
		}

		return self;
	}
})