try {
    docfx docs\docfx.json --serve --port 8081
} finally {
    Write-Host "Closed DoxFX server."
    [Environment]::Exit(0)
}