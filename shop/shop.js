//prototype item

function Item(images, name, price) {
				this.name = name
				this.price = price
				this.images = images;
				this.add = function() {
					
					console.log("Lista: " + this.images);
					console.log("Nazwa: " + this.name);
					
					let box = document.createElement("div");
					document.getElementById("container").appendChild(box);
					box.innerHTML = this.name;
				}
			}
const n1 = new Item(["aaa", "bbb", "ccc"], 'Bluza', 1222);
n1.add();