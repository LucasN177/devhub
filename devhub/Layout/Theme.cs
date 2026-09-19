using MudBlazor;

namespace devhub.Layout;

public static class Theme
{
    public static readonly MudTheme FirstTheme = new()
    {
        PaletteLight = new PaletteLight
        {
            Primary = "#5B5CE2",
            PrimaryContrastText = "#FFFFFF",

            Secondary = "#0891B2",
            SecondaryContrastText = "#FFFFFF",

            Tertiary = "#8B5CF6",

            Success = "#10B981",
            Info = "#0EA5E9",
            Warning = "#F59E0B",
            Error = "#F43F5E",

            Dark = "#0B1120",

            TextPrimary = "#111827",
            TextSecondary = "#667085",

            Background = "#F6F7FB",
            Surface = "#FFFFFF",

            DrawerBackground = "#FFFFFF",
            DrawerText = "#475467",

            AppbarBackground = "#FFFFFF",
            AppbarText = "#111827"
        },

        PaletteDark = new PaletteDark
        {
            Primary = "#818CF8",
            PrimaryContrastText = "#0B1120",

            Secondary = "#22D3EE",
            SecondaryContrastText = "#082F49",

            Tertiary = "#A78BFA",

            Success = "#34D399",
            Info = "#38BDF8",
            Warning = "#FBBF24",
            Error = "#FB7185",

            Dark = "#020617",

            TextPrimary = "#F8FAFC",
            TextSecondary = "#94A3B8",

            Background = "#080B12",
            Surface = "#11151F",

            DrawerBackground = "#0D111A",
            DrawerText = "#A7B0C0",

            AppbarBackground = "#0D111A",
            AppbarText = "#F8FAFC"
        },

        Typography = new Typography
        {
            Default = new DefaultTypography
            {
                FontFamily = new[]
                {
                    "Inter",
                    "SF Pro Display",
                    "SF Pro Text",
                    "Roboto",
                    "Helvetica",
                    "Arial",
                    "sans-serif"
                },
                FontSize = "0.9375rem",
                FontWeight = "400",
                LetterSpacing = "0"
            },

            H1 = new H1Typography
            {
                FontSize = "2.25rem",
                FontWeight = "700",
                LetterSpacing = "-0.035em",
                LineHeight = "1.15"
            },

            H2 = new H2Typography
            {
                FontSize = "1.875rem",
                FontWeight = "700",
                LetterSpacing = "-0.03em",
                LineHeight = "1.2"
            },

            H3 = new H3Typography
            {
                FontSize = "1.5rem",
                FontWeight = "700",
                LetterSpacing = "-0.025em",
                LineHeight = "1.25"
            },

            H4 = new H4Typography
            {
                FontSize = "1.25rem",
                FontWeight = "650",
                LetterSpacing = "-0.015em"
            },

            H5 = new H5Typography
            {
                FontSize = "1.125rem",
                FontWeight = "600",
                LetterSpacing = "-0.01em"
            },

            H6 = new H6Typography
            {
                FontSize = "1rem",
                FontWeight = "600"
            },

            Button = new ButtonTypography
            {
                FontSize = "0.875rem",
                TextTransform = "none",
                FontWeight = "600",
                LetterSpacing = "-0.005em"
            }
        },

        Shadows = new Shadow
        {
            Elevation = new[]
            {
                "none",

                "0 1px 2px rgba(16, 24, 40, 0.04)",

                "0 1px 3px rgba(16, 24, 40, 0.06), " +
                "0 1px 2px rgba(16, 24, 40, 0.03)",

                "0 2px 6px rgba(16, 24, 40, 0.07), " +
                "0 1px 3px rgba(16, 24, 40, 0.04)",

                "0 6px 16px rgba(16, 24, 40, 0.08), " +
                "0 2px 6px rgba(16, 24, 40, 0.04)",

                "0 12px 28px rgba(16, 24, 40, 0.10), " +
                "0 4px 10px rgba(16, 24, 40, 0.05)",

                "0 20px 40px rgba(16, 24, 40, 0.12), " +
                "0 8px 16px rgba(16, 24, 40, 0.06)"
            }
        },

        ZIndex = new ZIndex
        {
            Drawer = 1100,
            AppBar = 1200,
            Dialog = 1300,
            Snackbar = 1400,
            Tooltip = 1500
        },

        LayoutProperties = new LayoutProperties
        {
            DefaultBorderRadius = "12px",
            DrawerWidthLeft = "260px",
            DrawerWidthRight = "260px",
            AppbarHeight = "64px"
        }
    };
}
