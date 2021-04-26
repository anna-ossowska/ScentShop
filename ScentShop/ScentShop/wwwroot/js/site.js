const testimonialsContainer = document.querySelector('testimonials-container');
const testimonial = document.querySelector('.testimonial');
const userImg = document.querySelector('.user-img');
const userName = document.querySelector('.user-name');
const userCountry = document.querySelector('.country');

const testimonialsStorage = [
    {
        name: 'Liv Jensen',
        country: 'Norway',
        photo:
            'https://res.cloudinary.com/do0ohxztp/image/upload/v1619433279/testimonials/testimonial-1_aiezoy.png',
        text:
            "I had no idea that my favorite vintage perfumes were still available, and at such good prices. I just discovered this website a couple of weeks ago thanks to my friend, and I've already placed two orders.",
    },
    {
        name: 'Todd Holmes',
        country: 'Canada',
        photo:
            'https://res.cloudinary.com/do0ohxztp/image/upload/v1619433279/testimonials/testimonial-2_w97wpy.png',
        text:
            "Wanted to get my wife her favorite perfume for her birthday. I found it here at a good price and received great service. I ordered on a Friday and received Monday! I'm extremely pleased and will definitely buy from here again.",
    },
    {
        name: 'Maria Rossi',
        country: 'Italy',
        photo:
            'https://res.cloudinary.com/do0ohxztp/image/upload/v1619433279/testimonials/testimonial-3_hapv6w.png',
        text:
            'I had a confirmation order within minutes of placing my order and a few hours later an update stating my order was package and being shipped. My experience was fantastic for first time ordering!',
    },
    {
        name: 'Karl Weber',
        country: 'Germany',
        photo:
            'https://res.cloudinary.com/do0ohxztp/image/upload/v1619433279/testimonials/testimonial-4_ct0f9a.png',
        text:
            "Always a pleasure to purchase from your store. Have never been disappointed with the perfume I've ordered. Great shipping time, packaging and contact with the client. Thank you for your services!",
    },
];

let indx = 1;

function updateTestimonial() {
    // Pulling data from the testimonialsStorage, depending on current index
    const { name, country, photo, text } = testimonialsStorage[indx];

    userName.innerHTML = name;
    userCountry.innerHTML = country;
    userImg.src = photo;
    testimonial.innerHTML = text;

    indx++;

    if (indx > testimonialsStorage.length - 1) {
        indx = 0;
    }
}

setInterval(updateTestimonial, 10000);