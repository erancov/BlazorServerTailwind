module.exports = {
    content: ['./*/*.{razor,html,cshtml}'],
    theme: {
        extend: {
            height: {
                'top-bottom': 'calc(100vh - 3.5rem)'
            }

        },
    },
    plugins: [
        require('@tailwindcss/typography')
    ],

}