// =========================================================
// Vikram Public School - Site JavaScript
// =========================================================

document.addEventListener('DOMContentLoaded', function () {

    /* ---------------------------------------------------
       1. Navbar Scroll Effect
    --------------------------------------------------- */
    var navbar = document.getElementById('mainNavbar');
    function handleNavbarScroll() {
        if (!navbar) return;
        if (window.scrollY > 60) {
            navbar.classList.add('scrolled');
        } else {
            navbar.classList.remove('scrolled');
        }
    }
    window.addEventListener('scroll', handleNavbarScroll);
    handleNavbarScroll();

    /* ---------------------------------------------------
       2. Smooth Scrolling for in-page anchor links
    --------------------------------------------------- */
    document.querySelectorAll('a[href^="#"]').forEach(function (anchor) {
        anchor.addEventListener('click', function (e) {
            var targetId = this.getAttribute('href');
            if (targetId.length > 1) {
                var target = document.querySelector(targetId);
                if (target) {
                    e.preventDefault();
                    window.scrollTo({
                        top: target.offsetTop - 90,
                        behavior: 'smooth'
                    });
                }
            }
        });
    });

    /* ---------------------------------------------------
       3. Back To Top Button
    --------------------------------------------------- */
    var backToTopBtn = document.getElementById('backToTop');
    function handleBackToTopVisibility() {
        if (!backToTopBtn) return;
        if (window.scrollY > 400) {
            backToTopBtn.classList.add('show');
        } else {
            backToTopBtn.classList.remove('show');
        }
    }
    window.addEventListener('scroll', handleBackToTopVisibility);
    handleBackToTopVisibility();

    if (backToTopBtn) {
        backToTopBtn.addEventListener('click', function () {
            window.scrollTo({ top: 0, behavior: 'smooth' });
        });
    }

    /* ---------------------------------------------------
       4. Gallery Filter (Gallery page)
    --------------------------------------------------- */
    var filterButtons = document.querySelectorAll('.filter-btn');
    var galleryItems = document.querySelectorAll('.gallery-item');

    if (filterButtons.length && galleryItems.length) {
        filterButtons.forEach(function (btn) {
            btn.addEventListener('click', function () {
                filterButtons.forEach(function (b) { b.classList.remove('active'); });
                this.classList.add('active');

                var filterValue = this.getAttribute('data-filter');

                galleryItems.forEach(function (item) {
                    var category = item.getAttribute('data-category');
                    if (filterValue === 'all' || category === filterValue) {
                        item.classList.remove('hide-item');
                    } else {
                        item.classList.add('hide-item');
                    }
                });
            });
        });
    }

    /* ---------------------------------------------------
       5. Simple Bootstrap-style Form Validation
    --------------------------------------------------- */
    var forms = document.querySelectorAll('.needs-validation');
    Array.prototype.slice.call(forms).forEach(function (form) {
        form.addEventListener('submit', function (event) {
            if (!form.checkValidity()) {
                event.preventDefault();
                event.stopPropagation();
            }
            form.classList.add('was-validated');
        }, false);
    });

    /* ---------------------------------------------------
       6. Image Hover Micro-interaction (gallery & cards)
       Adds a subtle "lifted" class on mouse enter for
       touch/keyboard friendliness beyond pure CSS :hover
    --------------------------------------------------- */
    document.querySelectorAll('.gallery-card, .highlight-card, .news-card').forEach(function (card) {
        card.addEventListener('mouseenter', function () {
            card.classList.add('is-hovered');
        });
        card.addEventListener('mouseleave', function () {
            card.classList.remove('is-hovered');
        });
    });

});
