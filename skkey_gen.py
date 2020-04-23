# this file is full of garbage code left from a kinf of extract from original create_plots script from Chia.
# it display all of your calculate and display all your sk_key instantly. You need a valid plots.yaml
# it can works if you input the same parameters as if you were gonna plot.
# it doesn't write to files anymore. Just read and display.
# so i was calling it this way if i had 10 plots in config file and all.
#
# chia-skkey-gen -k 31 -n 10 -t /mnt/g/working -d /mnt/e/plots
#
# -k must be same as your plots


import argparse
from pathlib import Path

from blspy import PrivateKey

from src.util.config import config_path_for_filename, load_config
from src.util.default_root import DEFAULT_ROOT_PATH
from src.util.path import path_from_root


def main():
    """
    Script for creating plots and adding them to the plot config file.
    """
    root_path = DEFAULT_ROOT_PATH
    plot_config_filename = config_path_for_filename(root_path, "plots.yaml")
    key_config_filename = config_path_for_filename(root_path, "keys.yaml")

    parser = argparse.ArgumentParser(description="Chia plotting script.")
    parser.add_argument("-k", "--size", help="Plot size", type=int, default=20)
    parser.add_argument(
        "-n", "--num_plots", help="Number of plots", type=int, default=10
    )
    parser.add_argument("-i", "--index", help="First plot index", type=int, default=0)
    parser.add_argument(
        "-p", "--pool_pub_key", help="Hex public key of pool", type=str, default=""
    )
    parser.add_argument(
        "-t",
        "--tmp_dir",
        help="Temporary directory for plotting files (relative to final directory)",
        type=Path,
        default=Path("./plots.tmp"),
    )

    new_plots_root = path_from_root(
        root_path,
        load_config(root_path, "config.yaml")
        .get("harvester", {})
        .get("new_plot_root", "plots"),
    )
    parser.add_argument(
        "-d",
        "--final_dir",
        help="Final directory for plots (relative or absolute)",
        type=Path,
        default=new_plots_root,
    )

    # We need the keys file, to access pool keys (if the exist), and the sk_seed.
    args = parser.parse_args()
    if not key_config_filename.exists():
        raise RuntimeError("Keys not generated. Run chia-generate-keys")

    # The seed is what will be used to generate a private key for each plot
    key_config = load_config(root_path, key_config_filename)
    sk_seed: bytes = bytes.fromhex(key_config["sk_seed"])


    for i in range(args.index, args.index + args.num_plots):
        # Generate a sk based on the seed, plot size (k), and index
        sk: PrivateKey = PrivateKey.from_seed(
            sk_seed + args.size.to_bytes(1, "big") + i.to_bytes(4, "big")
        )
        print(f"sk: {bytes(sk).hex()}")


if __name__ == "__main__":
    main()
