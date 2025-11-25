document.addEventListener('DOMContentLoaded', () => {
    const tabButtons = document.querySelectorAll('[data-tab-target]');

    tabButtons.forEach(btn => {
        btn.addEventListener('click', () => {
            const targetId = btn.dataset.tabTarget;
            document.querySelectorAll('[data-tab-content]').forEach(panel => {
                panel.classList.toggle('hidden', panel.id !== targetId);
            });
            tabButtons.forEach(b => b.classList.toggle('active', b === btn));
        });
    });
});
